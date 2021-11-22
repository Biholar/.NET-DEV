using CryptoIdentityWebApi.Entity;
using CryptoIdentityWebApi.Services.Interfaces;
using MongoDB.Driver;
using System;
using System.Security.Cryptography;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CryptoIdentityWebApi.Services
{
    public class UserService : IUserService
    {
        private readonly IMongoClient _client;
        private readonly IMongoCollection<User> _collection;

        public UserService(IMongoClient client)
        {
            _client = client;
            _collection = client.GetDatabase("CryptoIdentity").GetCollection<User>("User");
        }

        public async Task<string> AddUser(User user)
        {
            var Id = await AutoId<User>.GetId(_client);

            user.Id = ++Id;

            await _collection.InsertOneAsync(user);

            await AutoId<User>.SetId(_client, Id);

            return await GetUserToken(user);
        }

        public async Task DeleteUser(int userId)
        {
            await _collection.DeleteOneAsync(Builders<User>.Filter.Eq(u => u.Id, userId));
        }

        public async Task<IEnumerable<User>> GetUsersForFile(int fileId)
        {

            var usersId = _client.GetDatabase("CryptoIdentity").GetCollection<FileUser>("FileUser").FindAsync(Builders<FileUser>.Filter.Eq(fu => fu.FileId, fileId)).Result.ToListAsync().Result.Select((user) => user.Id);

            var users = await _collection.FindAsync(Builders<User>.Filter.In(u => u.Id, usersId)).Result.ToListAsync();

            return users;

        }

        public Task<string> GetUserToken(User user)
        {
            var header = JsonSerializer.Serialize(new
            {
                alg = "My",
                typ = "JWT"
            });

            header = Convert.ToBase64String(Encoding.ASCII.GetBytes(header));

            var body = Convert.ToBase64String(Encoding.ASCII.GetBytes(JsonSerializer.Serialize(user)));

            HMACSHA256 hmac = new HMACSHA256(Encoding.ASCII.GetBytes("mysecretserversecret"));

            var hash = Convert.ToBase64String(hmac.ComputeHash(Encoding.ASCII.GetBytes(header + '.' + body)));

            return Task.FromResult(header + '.' + body + '.' + hash);
        }

        public async Task<bool> IsTokenValid(string token)
        {
            try
            {
                token = token.Replace("%2F", "/");
                var block = token.Split('.');

                HMACSHA256 hmac = new HMACSHA256(Encoding.ASCII.GetBytes("mysecretserversecret"));

                if (block[2] != Convert.ToBase64String(hmac.ComputeHash(Encoding.ASCII.GetBytes(block[0] + '.' + block[1]))))
                    return false;

                var user = JsonSerializer.Deserialize<User>(Convert.FromBase64String(block[1]));

                var result = await _collection.FindAsync(Builders<User>.Filter.Eq(u => u.Id, user.Id)).Result.FirstOrDefaultAsync();

                if (result.Id < 1)
                    return false;

                if (result.Id != user.Id && result.Pass != user.Pass)
                    return false;

                return true;
            }

            catch (Exception)
            {
                return false;
            }
        }

        public User GetUserFromToken(string token)
        {
            var block = token.Split('.');

            return JsonSerializer.Deserialize<User>(Convert.FromBase64String(block[1]));
        }
    }
}
