using System;
using Core.Entities.Concrete;
using Entities.Concrete;

namespace Business.Constants
{
	public  static class Messages// static yaptıgımız için newlememize gerek kalmadı
	{
        public static string MaintenanceTime = "Sistem Bakımda";
        public static string ProductAdded = "Ürün Eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string ProductsListed = "Ürünler Listelendi";
        internal static string ProductCountOfCategoryError;
        internal static string ProductNameAlReadyExists;
        internal static string CategoryLimitExceded;
        public static string UnitPriceInvalid { get; internal set; }
        public static string UserRegistered = "Kayıt olundu";
        public static string UserNotFound = "Kullancı Bulunamadı";
        public static string PasswordError = "Parola Hatası";
        public static string SuccessfulLogin = "Giriş Başarılı";
        public static string UserAlreadyExists = "Böyle Bir kullanıcı var zaten";
        public static string AccessTokenCreated = "Token Oluşturuldu";

        public static string AuthorizationDenied = "Yetkiniz Yok";
    }
}

