using CryptoIdentityWebApi.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CryptoIdentityWebApi.Services.Interfaces
{
    public interface IFileService
    {
        Task AddFile(File file);
        Task ChangeFileAccess(int fileId);
        Task DeleteFile(int fileId);
        Task<string> GetFileContent(int fileId);
        Task SetFileContent(int fileId, string content);
        Task<IEnumerable<File>> GetFilesForUser(int userId);
        Task<bool> IsFilePublic(int fileId);
    }
}
