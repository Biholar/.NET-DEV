using MongoDBWebAPI.Models;
using MongoDBWebAPI.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MongoDBWebAPI.Services
{
    public class CarService : ICarService
    {
        private readonly ICarRepository _carRepository;

        public CarService(ICarRepository carRepository) { _carRepository = carRepository; }

        public async Task Create(Car car)
        {
             await _carRepository.Create(car);
        }

        public async Task<bool> Delete(int Id)
        {
            return await _carRepository.Delete(Id);
        }

        public async Task<Car> Get(int Id)
        {
            return await _carRepository.Get(Id);
        }

        public async Task<IEnumerable<Car>> Get()
        {
            return await _carRepository.Get();
        }

        public async Task<IEnumerable<Car>> GetByMake(string make)
        {
            return await _carRepository.GetByMake(make);
        }

        public async Task Update(int Id, Car car)
        {
            await _carRepository.Update(Id, car);
        }
    }
}
