using MongoDB.Driver;
using MongoDBWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MongoDBWebAPI.Repositories
{
    public class GenericRepository<TEntity, TId> : IGenericRepository<TEntity, TId> where TEntity : class, IEntity<TId>
    {
        private readonly IMongoCollection<TEntity> _collection;

        public GenericRepository(IMongoClient client)
        {
            var database = client.GetDatabase("CarShop");
            var collection = database.GetCollection<TEntity>(typeof(TEntity).Name);

            _collection = collection;
        }

        public async Task Create(TEntity car)
        {
            await _collection.InsertOneAsync(car);

        }

        public async Task<bool> Delete(TId Id)
        {
            var filter = Builders<TEntity>.Filter.Eq(c => c.Id, Id);
            var result = await _collection.DeleteOneAsync(filter);

            return result.DeletedCount == 1;
        }

        public async Task<TEntity> Get(TId Id)
        {
            var filter = Builders<TEntity>.Filter.Eq(c => c.Id, Id);
            var car = await _collection.Find(filter).FirstOrDefaultAsync();

            return car;
        }

        public async Task<IEnumerable<TEntity>> Get()
        {
            var cars = await _collection.Find(_ => true).ToListAsync();

            return cars;
        }


        public async Task Update(TId Id, TEntity car)
        {
            await _collection.ReplaceOneAsync(e => e.Id.Equals(Id), car);

        }
    }
}
