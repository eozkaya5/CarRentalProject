using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Contants
{
    public static class Messages
    {
        public static string Added = "Ekleme işlemi başarılı bir şekilde gerçekleşmiştir.";
        public static string Deleted = "Silme işlemi başarılı bir şekilde gerçekleşmiştir.";
        public static string Listed = "Listeleme işlemi başarılı bir şekilde gerçekleşmiştir.";
        public static string Updated = "Güncelleme işlemi başarılı bir şekilde gerçekleşmiştir.";
        public static string MaintenanceTime = "Sistem bakımdadır. Daha sonra tekrar deneyiniz.";
        public static string CarImageLimitExceeded = "Beşten fazla resim eklenemez.";

        public static string UserRegistered = "Kullanıcı eklendi.";
        public static string UserNotFound = "Kullanıcı bulunamadı.";
        public static string PasswordError = "Şifre hatalı !";
        public static string SuccessfulLogin = "Giriş başarılı.";      
        public static string UserAlreadyExists = "Kullanıcı Mevcut";
        public static string AccessTokenCreated = "Token Oluşturuldu.";
    }
}
