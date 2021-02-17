using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages // new'lenmemesi için static yaptık
    {
        //CarManager
        public static string CarAdded = "Araba başarıyla eklendi!";
        public static string CarPriceInvalid = "Arabanın günlük fiyatı sıfırdan büyük olmalıdır!";
        public static string CarDeleted = "Araba başarıyla silindi.";
        public static string CarUpdated = "Araba başarıyla güncellendi";
        public static string MaintenanceTime = "Sistem bakımdadır. Lütfen daha sonra tekrar deneyiniz!";
        public static string CarListed = "Arabalar listelendi.";

        //BrandManager
        public static string BrandAdded = "Marka başarıyla eklendi!";
        public static string BrandUpdated = "Marka başarıyla güncelledi.";
        public static string BrandDeleted = "Marka başarıyla silindi!";
        public static string BrandNameInvalid = "Marka adı hatalı. En az iki karakterli olmalı!";

        //ColorManager
        public static string ColorAdded = "Renk başarıyla eklendi!";
        public static string ColorUpdated = "Renk başarıyla güncellendi.";
        public static string ColorDeleted = "Renk başarıyla silindi.";

        //CustomerManager
        public static string CustomerAdded = "Müşteri eklendi.";
        public static string CustomerDeleted = "Müşteri silindi.";
        public static string CustomerUpdated = "Müşteri güncellendi.";

        //UserManager
        public static string UserAdded = "Kullanıcı eklendi.";
        public static string UserDeleted = "Kullanıcı silindi.";
        public static string UserUpdated = "Kullanıcı güncellendi.";

        //RentalManager
        public static string RentAdded = "Araba kiralama işlemi baraşıyla gerçekleşti!";
        public static string RentInvalid = "Araba henüz teslim edilmediği için kiralama işlemi gerçekleştirilemez!";
        public static string RentalReturned = "Araba iade işlemi baraşıyla gerçekleşti.";
    }
}
