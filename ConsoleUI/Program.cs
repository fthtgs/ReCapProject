using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
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
            //CarDetailTest();
            //GetCarTest();
            //GetColor();
            //GetBrand();
            //AddBrandTest();
            //UserAddTest();
            //CustomerAddTest();


            CarManager carManager = new CarManager(new EfCarDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            UserManager userManager = new UserManager(new EfUserDal());
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            //RentalAdd(rentalManager); 
            //RentalReturnedTest(rentalManager);

        }

        private static void RentalReturnedTest(RentalManager rentalManager)
        {
            Console.WriteLine("Kiraladığınız araba hangi Car Id'ye sahip?");
            int carId = Convert.ToInt32(Console.ReadLine());
            rentalManager.RentReturned(carId);
        }

        private static void RentalAdd(RentalManager rentalManager)
        {
            Console.WriteLine("Car Id: ");
            int carIdForAdd = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Customer Id: ");
            int customerIdForAdd = Convert.ToInt32(Console.ReadLine());

            Rental rent1 = new Rental()
            {
                CarId = carIdForAdd,
                CustomerId = customerIdForAdd,
                RentDate = DateTime.Now,
                ReturnDate = null
            };

            var result = rentalManager.Add(rent1);
            Console.WriteLine(result.Message);
        }

        private static void CustomerAddTest()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            Customer customer1 = new Customer() { UserId = 2, CustomerName = "Kaan's Company" };
            customerManager.Add(customer1);
            foreach (var customer in customerManager.GetAll().Data)
            {
                Console.WriteLine($"{customer.UserId}, {customer.CustomerName}");
            }
        }

        private static void UserAddTest()
        {
            UserManager userManager = new UserManager(new EfUserDal());
            User user2 = new User() { FirstName = "Kaan", LastName = "Ramuk", Email = "kaan@gmail.com", Password = "12345" };
            userManager.Add(user2);
            foreach (var user in userManager.GetAll().Data)
            {
                Console.WriteLine($"{user.UserId}, {user.FirstName} {user.LastName}, {user.Email}");
            }
        }

        private static void AddBrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            Brand brand1 = new Brand { BrandName = "E" };
            brandManager.Add(brand1);
            Console.WriteLine(brandManager.Add(brand1).Message);
        }

        private static void GetBrand()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());

            foreach (var brand in brandManager.GetAll().Data)
            {
                Console.WriteLine(brand.BrandName);
            }
        }

        private static void GetColor()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());

            foreach (var color in colorManager.GetAll().Data)
            {
                Console.WriteLine(color.ColorName);
            }
        }

        private static void GetCarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.GetCars();

            if (result.Success == true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.CarName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void CarDetailTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.GetCarDetails();

            if (result.Success == true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.BrandName + "---" + car.CarName + "---" + car.ColorName + "---" + car.DailyPrice + "TL");
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        /*
        private static void Add_and_Delete()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            Car car1 = new Car { BrandId = 1,CarName = "Clio", ColorId = 1, DailyPrice = 180, ModelYear = 2018, Descriptions = "Otomatik - Dizel - Ekonomik" };

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
        */
    }
}
