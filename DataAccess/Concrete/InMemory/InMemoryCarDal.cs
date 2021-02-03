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
            //DataBase'deki arabaları simule etmek için
            _cars = new List<Car>
            {
                new Car{CarId = 1,BrandId = 1,ColorId = 1,ModelYear = 2018,DailyPrice = 300,Description = "AUDI A3 - Benzinli -  Otomatik"},
                new Car{CarId = 2,BrandId = 2,ColorId = 1,ModelYear = 2019,DailyPrice = 575,Description = "MERCEDES A-CLASS 1.3 A - Benzinli - Otomatik"},
                new Car{CarId = 3,BrandId = 2,ColorId = 2,ModelYear = 2019,DailyPrice = 575,Description = "MERCEDES A-CLASS A 180 - Dizel - Otomatik"},
                new Car{CarId = 4,BrandId = 3,ColorId = 3,ModelYear = 2016,DailyPrice = 500,Description = "BMW SERIES 1 - Benzinli -  Otomatik"},
                new Car{CarId = 5,BrandId = 4,ColorId = 3,ModelYear = 2016,DailyPrice = 165,Description = "Fiat Egea - Benzinli - Manuel"},
                new Car{CarId = 6,BrandId = 5,ColorId = 4,ModelYear = 2017,DailyPrice = 290,Description = "Dacia Duster 4X2 - Benzinli - Manuel"},
                new Car{CarId = 7,BrandId = 6,ColorId = 1,ModelYear = 2015,DailyPrice = 450,Description = "KIA Sportage - Dizel - Otomatik"},
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            var carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int carId)
        {
            return _cars.Where(c => c.CarId == carId).ToList();
        }

        public void Update(Car car)
        {
            var carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }
    }
}
