using AutoMapper;
using RVAProdavnica.Data;
using RVAProdavnica.Models;
using RVAProdavnica.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RVAProdavnica.Services
{
    public interface ICarService
    {
        List<CarModel> GetAll();

        CarModel getById(int id);

        //List<CarModel> TableSearch(int pageNumber, int rowsPerPage, string search);

        int? Create(CarModel obj);

        void Update(CarModel obj);

        void Delete(Car obj);
    }

    public class CarService : ICarService
    {
        private readonly ICarRepository carRepository;

        private readonly IMapper mapper;

        public CarService(ICarRepository carRepository, IMapper mapper)
        {
            this.carRepository = carRepository;
            this.mapper = mapper;
        }

        public int? Create(CarModel obj)
        {
            return carRepository.Create(mapper.Map<Car>(obj));
        }

        public List<CarModel> GetAll()
        {
            var resultFromDb = carRepository.GetAll();
            var resultModels = mapper.Map<List<CarModel>>(resultFromDb);

            return resultModels;
        }

        public CarModel getById(int id)
        {
            return mapper.Map<CarModel>(carRepository.GetOne(id));
        }

        public void Update(CarModel obj)
        {
            carRepository.Update(mapper.Map<Car>(obj));
        }

        public void Delete(Car obj)
        {
            carRepository.Delete(obj);
        }
    
    }

}
    