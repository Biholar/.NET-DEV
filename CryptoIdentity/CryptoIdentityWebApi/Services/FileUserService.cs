using CryptoIdentityWebApi.Entity;
using CryptoIdentityWebApi.Services.Interfaces;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CryptoIdentityWebApi.Services
{
    public class FileUserService : IFileUserService
    {
        private readonly IMongoClient _client;
        private readonly IMongoCollection<FileUser> _collection;

        public FileUserService(IMongoClient client)
        {
            _client = client;
            _collection = client.GetDatabase("CryptoIdentity").GetCollection<FileUser>("FileUser");
        }
        public async Task AddFileUser(FileUser user)
        {
            var Id = await AutoId<FileUser>.GetId(_client);

            user.Id = ++Id;

            await _collection.InsertOneAsync(user);

            await AutoId<FileUser>.SetId(_client, Id);
        }

        public async Task ChangeFileUserRole(int userId, int role)
        {
            var user = await _collection.FindAsync(Builders<FileUser>.Filter.Eq(u => u.Id, userId)).Result.FirstOrDefaultAsync();

            user.Role = role;

            await _collection.ReplaceOneAsync(u => u.Id.Equals(userId), user);
        }

        public async Task DeleteAllFileUsersByIdField(int id, string field)
        {
            await _collection.DeleteManyAsync(Builders<FileUser>.Filter.Eq(u => u.GetType().GetProperty(field).GetValue(u), id));
        }

        public async Task DeleteFileUser(int userId)
        {
            await _collection.FindOneAndDeleteAsync(Builders<FileUser>.Filter.Eq(u => u.Id, userId));
        }

        public async Task<int> UserPermission(int userId, int fileId)
        {
            try
            {
                var user = await _collection.FindAsync(Builders<FileUser>.Filter.Eq(u => u.Id, userId) & Builders<FileUser>.Filter.Eq(u => u.FileId, fileId)).Result.FirstOrDefaultAsync();

                return user.Role;
            }

            catch(Exception)
            {
                return 0;
            }
        }
    }
}
