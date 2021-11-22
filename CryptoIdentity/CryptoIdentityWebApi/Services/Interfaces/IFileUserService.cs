using CryptoIdentityWebApi.Entity;
using System.Threading.Tasks;

namespace CryptoIdentityWebApi.Services.Interfaces
{
    public interface IFileUserService
    {
        Task AddFileUser(FileUser user);
        Task<int> UserPermission(int userId, int fileId);
        Task ChangeFileUserRole(int userId, int role);
        Task DeleteFileUser(int userId);
        Task DeleteAllFileUsersByIdField(int id, string field);
    }
}
