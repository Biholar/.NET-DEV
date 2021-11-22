using CryptoIdentityWebApi.Entity;
using CryptoIdentityWebApi.Services.Interfaces;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CryptoIdentityWebApi.Services
{
    public class FileService : IFileService
    {
        private readonly IMongoClient _client;
        private readonly IMongoCollection<Entity.File> _collection;

        public FileService(IMongoClient client)
        {
            _client = client;
            _collection = client.GetDatabase("CryptoIdentity").GetCollection<Entity.File>("File");
        }

        public async Task AddFile(Entity.File file)
        {
            System.IO.File.Create(".\\Files\\" + file.Name);

            var Id = await AutoId<Entity.File>.GetId(_client);

            file.Id = ++Id;

            await _collection.InsertOneAsync(file);

            await AutoId<Entity.File>.SetId(_client, Id);
        }

        public async Task ChangeFileAccess(int fileId)
        {
            var file = await _collection.FindAsync(Builders<Entity.File>.Filter.Eq(f => f.Id, fileId)).Result.FirstOrDefaultAsync();

            file.Access = 1 - file.Access;

            await _collection.ReplaceOneAsync(f => f.Id.Equals(fileId), file);
        }

        public async Task DeleteFile(int fileId)
        {
            var file = await _collection.FindOneAndDeleteAsync(Builders<Entity.File>.Filter.Eq(f => f.Id, fileId));

            System.IO.File.Delete(".\\Files\\" + file.Name);
        }

        public async Task<string> GetFileContent(int fileId)
        {
            var file = await _collection.FindAsync(Builders<Entity.File>.Filter.Eq(f => f.Id, fileId)).Result.FirstOrDefaultAsync();

            return await System.IO.File.ReadAllTextAsync(".\\Files\\" + file.Name);
        }

        public async Task<IEnumerable<Entity.File>> GetFilesForUser(int userId)
        {
            var filesId =  _client.GetDatabase("CryptoIdentity").GetCollection<FileUser>("FileUser").FindAsync(Builders<FileUser>.Filter.Eq(fu => fu.UserId, userId)).Result.ToListAsync().Result.Select((file)=> file.Id);

            var files = await _collection.FindAsync(Builders<Entity.File>.Filter.In(f => f.Id, filesId)).Result.ToListAsync();

            files.AddRange(await _collection.FindAsync(Builders<Entity.File>.Filter.Eq(f => f.Access, 0)).Result.ToListAsync());

            return files;
        }

        public async Task<bool> IsFilePublic(int fileId)
        {
            var file = await _collection.FindAsync(Builders<Entity.File>.Filter.Eq(f => f.Id, fileId)).Result.FirstOrDefaultAsync();

            return file.Access == 0;
        }

        public async Task SetFileContent(int fileId, string content)
        {
            var file = await _collection.FindAsync(Builders<Entity.File>.Filter.Eq(f => f.Id, fileId)).Result.FirstOrDefaultAsync();

            await System.IO.File.WriteAllTextAsync(".\\Files\\" + file.Name, content);
        }
    }
}
