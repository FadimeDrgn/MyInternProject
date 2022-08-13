using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
