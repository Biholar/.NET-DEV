using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CryptoIdentityWebApi.Services
{
    public static class AutoId<TEntity>
    {
        public static async Task<int> GetId(IMongoClient client)
        {
            var data = await client.GetDatabase("CryptoIdentity").GetCollection<BsonDocument>("EntityId").AsQueryable().ToListAsync();

            return data[0][typeof(TEntity).Name + "Id"].AsInt32;
        }

        public static async Task SetId(IMongoClient client, int id)
        {
            var collection = client.GetDatabase("CryptoIdentity").GetCollection<BsonDocument>("EntityId");

            var data = await collection.AsQueryable().ToListAsync();

            data[0][typeof(TEntity).Name + "Id"] = id;

            await collection.ReplaceOneAsync(Builders<BsonDocument>.Filter.Eq("_id", data[0]["_id"]), data[0].ToBsonDocument());
        }
    }
}
