using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    //static: newlemeden kullanma sğalar.
    public static class Messages
    {
        public static string ProductAdded = "Ürün Eklendi.";
        public static string ProductNameInvalid = "Ürün ismi geçersiz.";
        public static string MaintenanceTime="sistem bakımda";
        public static string ProductsListed="ürün listelendi";

        public static string ProductCountOfCategoryError = "10'dan fazla eklenemez.";

        public static string ProductNameAlreadyExists = "Bu ürün daha önce eklenmiş";
        public static string CategoryLimitedExceded="Limit Aşıldı";
        public static string AuthorizationDenied="yetkiniz yok";
        internal static User UserNotFound;
        internal static string UserAlreadyExists;
        internal static string AccessTokenCreated="yetkiniz yok";
        internal static string SuccessfulLogin;
        internal static User PasswordError;
        internal static string UserRegistered;
        // public static string MaintenanceTime = "Sistem Bakımda.";
    }
}
