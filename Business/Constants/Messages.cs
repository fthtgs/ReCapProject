using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages // new'lenmemesi için static yaptık
    {
        public static string CarAdded = "Araba başarıyla eklendi!";
        public static string CarPriceInvalid = "Arabanın günlük fiyatı sıfırdan büyük olmalıdır!";
        public static string CarDeleted = "Araba başarıyla silindi.";
        public static string CarUpdated = "Araba başarıyla güncellendi";
        public static string MaintenanceTime = "Sistem bakımdadır. Lütfen daha sonra tekrar deneyiniz!";
        public static string BrandAdded = "Marka başarıyla eklendi!";
        public static string ColorAdded = "Renk başarıyla eklendi!";
        public static string BrandNameInvalid = "Marka adı hatalı. En az iki karakterli olmalı!";
        public static string RentAdded = "Kiralama başarılı!";
        public static string RentInvalid = "Kiralama gerçekleştirilemez. Ürün müsait değil.";
        public static string FailedRentalAddOrUpdate = "Araba henüz teslim edilmediği için kiralanamaz";
        public static string AddedRental = "Araba kiralama işlemi baraşıyla gerçekleşti.";
        public static string ReturnedRental = "Araba iade işlemi baraşıyla gerçekleşti.";
    }
}
