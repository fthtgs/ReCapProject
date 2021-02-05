using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetCars();
        List<Car> GetCarsByBrandId(int id);
        List<Car> GetByDailyPrice(decimal min, decimal max);
        List<Car> GetCarsByColorId(int id);

        void Add(Car car);
        void Delete(Car car);
        void Update(Car car);
    }
}
