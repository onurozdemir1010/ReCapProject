using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> { 
                new Car{BrandId =1, CarId =1, ColorId =1, DailyPrice =75000, ModelYear =2010, Description ="Citroen C4"},
                new Car{BrandId =2, CarId =2, ColorId =2, DailyPrice =85000, ModelYear =2011, Description ="Honda Civic"},
                new Car{BrandId =3, CarId =3, ColorId =2, DailyPrice =170000, ModelYear =2015, Description ="Mercedes C180"},
                new Car{BrandId =4, CarId =4, ColorId =2, DailyPrice =50000, ModelYear =2009, Description ="Hyundai i20"},
                new Car{BrandId =5, CarId =5, ColorId =3, DailyPrice =145000, ModelYear =2015, Description ="Volvo S60"},
                new Car{BrandId =6, CarId =6, ColorId =1, DailyPrice =91000, ModelYear =2014, Description ="Volkswagen Golf"}
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAllById(int carsId)
        {
            return _cars.Where(c => c.CarId == carsId).ToList();//sql where koşulu ile aynı 
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.CarId = car.CarId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
