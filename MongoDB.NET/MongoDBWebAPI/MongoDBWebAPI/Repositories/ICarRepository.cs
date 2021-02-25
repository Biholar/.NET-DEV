using MongoDB.Bson;
using MongoDBWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MongoDBWebAPI.Repositories
{
    public interface ICarRepository : IGenericRepository<Car , int>
    {
        Task<IEnumerable<Car>> GetByMake(string make);
    }
}
