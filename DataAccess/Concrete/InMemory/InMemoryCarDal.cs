using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> { 
                new Car{BrandId =1, Id =1, ColorId =1, DailyPrice =75000, ModelYear ="2010", Description ="Citroen C4"},
                new Car{BrandId =2, Id =2, ColorId =2, DailyPrice =85000, ModelYear ="2011", Description ="Honda Civic"},
                new Car{BrandId =3, Id =3, ColorId =2, DailyPrice =170000, ModelYear ="2015", Description ="Mercedes C180"},
                new Car{BrandId =4, Id =4, ColorId =2, DailyPrice =50000, ModelYear ="2009", Description ="Hyundai i20"},
                new Car{BrandId =5, Id =5, ColorId =3, DailyPrice =145000, ModelYear ="2015", Description ="Volvo S60"},
                new Car{BrandId =6, Id =6, ColorId =1, DailyPrice =91000, ModelYear ="2014", Description ="Volkswagen Golf"}
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAllById(int carsId)
        {
            return _cars.Where(c => c.Id == carsId).ToList();//sql where koşulu ile aynı 
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.Id = car.Id;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
