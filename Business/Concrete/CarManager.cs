using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }
        public void Add(Car car)
        {
            if (car.DailyPrice > 1000)
            {
                _carDal.Add(car);
                Console.WriteLine("Sisteme yeni araba eklendi "+car);
            }
            else
            {
                Console.WriteLine("Lütfen 1000 liranın üzerinde bir rakam giriniz");
            }
        }
        public void Delete(Car car)
        {
            _carDal.Delete(car);
            Console.WriteLine(car+ "Adlı araç sistemden kaldırılmıştır");
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }
        public List<Car> GetAllByBrandId(int id)
        {
            return _carDal.GetAll(c => c.BrandId == id);
        }

        public List<CarDetailDto> GetCarDetails()
        {
            return _carDal.GetCarDetails();
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
        }
    }
}
