using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string MaintenanceTime = "Sistem bakımda" ;
        public static string ProductListed = "Ürünler listelendi";
        public static string ProductUpdated = "Ürün güncellendi";
        public static string ProductDeleted = "Ürün silindi";
        public static string ProductCountOfCategoryError = "Kategoride en fazla 15 ürün olabilir.";
        public static string ProductNameAlreadyExsists = "Bu isimde zaten başka bir ürün var";

        public static string CategoryListed = "Kategoriler listelendi";
        public static string CategoryAdded = "Kategori eklendi";
        public static string CategoryDeleted = "Kategori silindi";
        public static string CategoryLimitExceded = "Kategori limiti aşıldığı için yeni ürün eklenemiyor";


        public static string UserListed = "Kullanıcılar listelendi";
        public static string  AuthorizationDenied= "Yetkiniz yok";
        public static string UserRegistered = "Kullanıcı bulunamadı";
        public static string UserNotFound  ="Kullanıcı bulunamadı";
        public static string PasswordError = "Parola hatası";
        public static string SuccessfulLogin = "Başarılı giriş";
        public static string UserAlreadyExists = "Kullanıcı mevcut";
        public static string AccessTokenCreated = "AccessToken oluşturuldu";
        public static string UserAdded = "Kullanıcı eklendi";


        public static string CheckProductForDeleteImageError = "Bu id'ye ait resim bulunamadı" ;
        public static string CheckProductImageLımıtError = "Bir ürünün en fazla beş resmi olabilir";
        public static string ProductImageUpdated = "Ürün resmi güncellendi";
    }
}
