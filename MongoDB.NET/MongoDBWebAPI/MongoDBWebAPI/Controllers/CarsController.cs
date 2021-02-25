using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDBWebAPI.Models;
using MongoDBWebAPI.Repositories;
using MongoDBWebAPI.Services;

namespace MongoDBWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarsController : ControllerBase
    {
        private readonly ICarService _carService;

        public CarsController(ICarService carService)
        {
            _carService = carService;
        }

        [HttpPost]
        public async Task<IActionResult> Create(Car car)
        {
            await _carService.Create(car);

            return Ok();
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> Get(int Id)
        {
            var car = await _carService.Get(Id);

            return new JsonResult(car);
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var cars = await _carService.Get();

            return new JsonResult(cars);
        }

        [HttpGet("ByMake/{make}")]
        public async Task<IActionResult> GetByMake(string make)
        {
            var cars = await _carService.GetByMake(make);

            return new JsonResult(cars);
        }

        [HttpPut("{Id}")]
        public async Task<IActionResult> Update(int Id, Car car)
        {
            await _carService.Update(Id, car);

            return Ok();
        }

        [HttpDelete("{Id}")]
        public async Task<IActionResult> Delete(int Id)
        {
            var result = await _carService.Delete(Id);

            return Ok();
        }
    }
}
