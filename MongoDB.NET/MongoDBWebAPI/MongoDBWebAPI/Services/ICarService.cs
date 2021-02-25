using MongoDBWebAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MongoDBWebAPI.Services
{
    public interface ICarService
    {
        // Create
        Task Create(Car car);

        // Read
        Task<Car> Get(int Id);
        Task<IEnumerable<Car>> Get();
        Task<IEnumerable<Car>> GetByMake(string make);

        // Update
        Task Update(int Id, Car car);

        // Delete
        Task<bool> Delete(int Id);
    }
}