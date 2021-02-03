using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            // InMemory'deki arabalara tekrar ulaşmak için tanıttım
            List<Car> cars = new List<Car>
            {
                new Car{CarId = 1,BrandId = 1,ColorId = 1,ModelYear = 2018,DailyPrice = 300,Description = "AUDI A3 - Benzinli -  Otomatik"},
                new Car{CarId = 2,BrandId = 2,ColorId = 1,ModelYear = 2019,DailyPrice = 575,Description = "MERCEDES A-CLASS 1.3 A - Benzinli - Otomatik"},
                new Car{CarId = 3,BrandId = 2,ColorId = 2,ModelYear = 2019,DailyPrice = 575,Description = "MERCEDES A-CLASS A 180 - Dizel - Otomatik"},
                new Car{CarId = 4,BrandId = 3,ColorId = 3,ModelYear = 2016,DailyPrice = 500,Description = "BMW SERIES 1 - Benzinli -  Otomatik"},
                new Car{CarId = 5,BrandId = 4,ColorId = 3,ModelYear = 2016,DailyPrice = 165,Description = "Fiat Egea - Benzinli - Manuel"},
                new Car{CarId = 6,BrandId = 5,ColorId = 4,ModelYear = 2017,DailyPrice = 290,Description = "Dacia Duster 4X2 - Benzinli - Manuel"},
                new Car{CarId = 7,BrandId = 6,ColorId = 1,ModelYear = 2015,DailyPrice = 450,Description = "KIA Sportage - Dizel - Otomatik"},
            };

            //carManager çağırarak CarManager fonksiyonları kullanmamızı sağladı.
            CarManager carManager = new CarManager ( new InMemoryCarDal() );

            //Listeleme fonksiyonunu denemiş olduk.
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("Daily Price: "+ car.DailyPrice + "-" + car.Description);
            }


            Console.WriteLine("---------------------");
            //test için yeni bir araba ekledik ve Add fonksiyonunu denemiş olduk.
            Car testCar = new Car() { CarId = 9, BrandId = 3, ColorId = 2, ModelYear = 2015, DailyPrice = 25, Description = "Test Car" };
            carManager.Add(testCar);
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("Daily Price: " + car.DailyPrice + "-" + car.Description);
            }


            Console.WriteLine("---------------------");
            //Delete fonksiyonunu denemiş olduk.
            carManager.Delete(cars[0]);
            carManager.Delete(cars[2]);
            carManager.Delete(cars[4]);
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("Daily Price: " + car.DailyPrice + "-" + car.Description);
            }

                              


        }
    }
}
