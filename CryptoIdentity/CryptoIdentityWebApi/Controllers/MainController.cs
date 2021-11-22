using CryptoIdentityWebApi.Entity;
using CryptoIdentityWebApi.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.IO;

namespace CryptoIdentityWebApi.Controllers
{
    [ApiController]
    [Route("CryptoApi")]
    public class MainController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IFileService _fileService;
        private readonly IFileUserService _fileUserService;

        public MainController(IUserService userService, IFileService fileService, IFileUserService fileUserService)
        {
            _userService = userService;
            _fileService = fileService;
            _fileUserService = fileUserService;
        }

        [Route("user")]
        [HttpPost]
        public async Task<IActionResult> CreateUser([FromBody] User user)
        {
            await LogUserInfo($"Create user: {user.Name}");

            var result = await _userService.AddUser(user);

            return Ok(result);
        }

        [Route("user/{Id}")]
        [HttpDelete]
        public async Task<IActionResult> DeleteUser(int Id)
        {
            await LogUserInfo($"Delete user: {Id} and him permissions");

            await _userService.DeleteUser(Id);

            await _fileUserService.DeleteAllFileUsersByIdField(Id, "UserId");

            return Ok();
        }

        [Route("user/token")]
        [HttpPost]
        public async Task<IActionResult> GetUserToken([FromBody] User user)
        {
            await LogUserInfo($"Get token for user: {user.Id}");

            var result = await _userService.GetUserToken(user);

            return Ok(result);
        }

        [Route("user/token/valid/{token}")]
        [HttpPost]
        public async Task<IActionResult> IsTokenValid(string token)
        {
            var result = await _userService.IsTokenValid(token);

            await LogUserInfo($"Token: {token} is " + (result? "valid" : "invalid"));

            return Ok(result);
        }

        [Route("file")]
        [HttpPost]
        public async Task<IActionResult> CreateFile([FromHeader] string token, [FromBody] Entity.File file)
        {
            await LogFileInfo("User: " + _userService.GetUserFromToken(token).Id + " try to create a file");

            if (token == null)
                return BadRequest("You do not have permission to create the file!");

            if (!await _userService.IsTokenValid(token))
                return BadRequest("Incorrect token!");

            await _fileService.AddFile(file);

            await _fileUserService.AddFileUser(new FileUser
            {
                Id = 0,
                FileId = file.Id,
                UserId = _userService.GetUserFromToken(token).Id,
                Role = 4
            });

            return Ok();
        } 

        [Route("files/content/{Id}")]
        [HttpGet]
        public async Task<IActionResult> GetFileContent([FromHeader] string token, int Id)
        {
            await LogFileInfo("User: " + _userService.GetUserFromToken(token).Id + " try to read the file: " + Id);

            if (!await _fileService.IsFilePublic(Id))
            {
                if (token == null)
                    return BadRequest("You do not have permission to read the file!");

                if (!await _userService.IsTokenValid(token))
                    return BadRequest("Incorrect token!");

                if (await _fileUserService.UserPermission(_userService.GetUserFromToken(token).Id, Id) < 1)
                    return BadRequest("You do not have permission to read the file!");
            }

            var result = await _fileService.GetFileContent(Id);

            return Ok(result);
        }

        [Route("files/content/{Id}")]
        [HttpPost]
        public async Task<IActionResult> SetFileContent([FromHeader] string token, [FromBody] string content, int Id)
        {
            await LogFileInfo("User: " + _userService.GetUserFromToken(token).Id + " try to write to the file: " + Id);

            if (!await _fileService.IsFilePublic(Id))
            {
                if (token == null)
                    return BadRequest("You do not have permission to write to the file!");

                if (!await _userService.IsTokenValid(token))
                    return BadRequest("Incorrect token!");

                if (await _fileUserService.UserPermission(_userService.GetUserFromToken(token).Id, Id) < 2)
                    return BadRequest("You do not have permission to write to the file!");
            }

            await _fileService.SetFileContent(Id, content);

            return Ok();
        }

        [Route("files/permission/{Id}")]
        [HttpPost]
        public async Task<IActionResult> AddUserPermission([FromHeader] string token, [FromBody] FileUser user, int Id)
        {
            await LogFileInfo("User: " + _userService.GetUserFromToken(token).Id + " try to add permissions for user: " + user.UserId + " to the file: " + Id);

            if (token == null)
                return BadRequest("You do not have permission to set user permissins for the file!");

            if (!await _userService.IsTokenValid(token))
                return BadRequest("Incorrect token!");

            if (await _fileUserService.UserPermission(_userService.GetUserFromToken(token).Id, Id) < 3)
                return BadRequest("You do not have permission to set user permissins for the file!");

            await _fileUserService.AddFileUser(new FileUser
            {
                Id = 0, 
                FileId = Id,
                UserId = user.UserId,
                Role = user.Role
            });

            return Ok();
        }


        [Route("file/{Id}")]
        [HttpDelete]
        public async Task<IActionResult> DeleteFile([FromHeader] string token, int Id)
        {
            await LogFileInfo("User: " + _userService.GetUserFromToken(token).Id + " try to delete the file: " + Id);

            if (token == null)
                return BadRequest("You do not have permission to delete the file!");

            if (!await _userService.IsTokenValid(token))
                return BadRequest("Incorrect token!");

            if (await _fileUserService.UserPermission(_userService.GetUserFromToken(token).Id, Id) < 4)
                return BadRequest("You do not have permission to delete the file!");

            await _fileService.DeleteFile(Id);

            await _fileUserService.DeleteAllFileUsersByIdField(Id, "FileId");

            return Ok();
        }

        [Route("loguser")]
        [HttpPost]
        public async Task LogUserInfo([FromBody] string info)
        {
            await System.IO.File.AppendAllTextAsync(".\\Logs\\UserLog.txt", info);
        }

        [Route("logfile")]
        [HttpPost]
        public async Task LogFileInfo([FromBody] string info)
        {
            await System.IO.File.AppendAllTextAsync(".\\Logs\\FileLog.txt", info);
        }
    }
}
