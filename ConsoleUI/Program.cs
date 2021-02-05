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
            brandManager.Add(new Brand { BrandName = "a"});






        }
    }
}
