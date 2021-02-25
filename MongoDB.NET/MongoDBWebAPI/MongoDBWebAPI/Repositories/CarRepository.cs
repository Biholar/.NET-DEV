using MongoDB.Driver;
using MongoDBWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MongoDBWebAPI.Repositories
{
    public class CarRepository :GenericRepository<Car, int>, ICarRepository
    {
        private readonly IMongoCollection<Car> _cars;

        public CarRepository(IMongoClient client) : base (client)
        {
            var database = client.GetDatabase("CarShop");
            var collection = database.GetCollection<Car>(nameof(Car));

            _cars = collection;
        }

        public async Task<IEnumerable<Car>> GetByMake(string make)
        {
            var filter = Builders<Car>.Filter.Eq(c => c.Make, make);
            var cars = await _cars.Find(filter).ToListAsync();

            return cars;
        }

    }
}
