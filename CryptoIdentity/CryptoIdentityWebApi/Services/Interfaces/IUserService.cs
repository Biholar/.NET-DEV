using CryptoIdentityWebApi.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CryptoIdentityWebApi.Services.Interfaces
{
    public interface IUserService
    {
        Task<string> AddUser(User user);
        Task DeleteUser(int userId);
        Task<string> GetUserToken(User user);
        Task<bool> IsTokenValid(string token);
        Task<IEnumerable<User>> GetUsersForFile(int fileId);
        User GetUserFromToken(string token);
    }
}
