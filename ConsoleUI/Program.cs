using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
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
            //FirstChange();    // 8. Gün 1. Ödev

            //Add_and_Delete();   // 9. Gün ödevi -- Add ve Delete denemesi
            CarManager carManager = new CarManager(new EfCarDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());

            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine(car.BrandName + "--" + car.ColorName + "--" + car.DailyPrice + "TL");
            }

        }

        private static void Add_and_Delete()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            Car car1 = new Car { BrandId = 1, ColorId = 1, DailyPrice = 180, ModelYear = 2018, Descriptions = "Otomatik - Dizel - Ekonomik" };

            carManager.Add(car1);
            foreach (var car in carManager.GetCars())
            {
                Console.WriteLine(car.Descriptions);
            }


            carManager.Delete(carManager.GetById(17)); // en son eklendiği için en sondaki araba id'si ile sildim.
            foreach (var car in carManager.GetCars())
            {
                Console.WriteLine(car.Descriptions);
            }
        }

        private static void FirstChange()
        {
            //Fonksiyonları kullanabilmek için tanıtımın yapılması
            CarManager carManager = new CarManager(new EfCarDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());

            //Markanın ID'sine göre listeleme
            Console.WriteLine("Marka ID'si 5 olanların listesi:");
            Console.WriteLine("Id\tColor Name\tBrand Name\tModel Year\tDaily Price\tDescriptions");
            foreach (var car in carManager.GetCarsByBrandId(5))
            {
                Console.WriteLine($"{car.CarId}\t{colorManager.GetByColorId(car.ColorId).ColorName}\t\t{brandManager.GetByBrandId(car.BrandId).BrandName}\t\t{car.ModelYear}\t\t{car.DailyPrice}\t\t{car.Descriptions}");
            }

            //Renk ID'sine göre listeleme
            Console.WriteLine("\nRenk ID'si 3 olanların listesi:");
            Console.WriteLine("Id\tColor Name\tBrand Name\tModel Year\tDaily Price\tDescriptions");
            foreach (var car in carManager.GetCarsByColorId(3))
            {
                Console.WriteLine($"{car.CarId}\t{colorManager.GetByColorId(car.ColorId).ColorName}\t\t{brandManager.GetByBrandId(car.BrandId).BrandName}\t\t{car.ModelYear}\t\t{car.DailyPrice}\t\t{car.Descriptions}");
            }

            // Fiyat aralığı belirterek listeleme
            Console.WriteLine("\nGünlük fiyat aralığı 300 ile 500 olan arabalar: \nId\tColor Name\tBrand Name\tModel Year\tDaily Price\tDescriptions");
            foreach (var car in carManager.GetByDailyPrice(300, 500))
            {
                Console.WriteLine($"{car.CarId}\t{colorManager.GetByColorId(car.ColorId).ColorName}\t\t{brandManager.GetByBrandId(car.BrandId).BrandName}\t\t{car.ModelYear}\t\t{car.DailyPrice}\t\t{car.Descriptions}");
            }

            Console.WriteLine("\n");

            //Yeni araba eklemeyi deneme - Hatalı ekleme
            carManager.Add(new Car { BrandId = 2, ColorId = 2, DailyPrice = -20, ModelYear = 2018, Descriptions = "Otomatik - Dizel - Ekonomi" });

            //Yeni marka eklemeyi deneme - Hatalı ekleme
            brandManager.Add(new Brand { BrandName = "a" });
        }
    }
}
