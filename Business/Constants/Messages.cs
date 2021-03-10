using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string ProductsListed = "Ürünler listelendi";
        public static string ProductCountOfCategoryError = "Kategori'deki ürün limiti aşıldı";
        public static string ProductNameAlreadyExists = "Aynı isimdeki ürün mevcut";
        public static string CategoryLimitExceded = "Category limiti aşıldığı için yeni ürün eklenemiyor";
        
        public static string CategoryAdded = "Kategori eklendi";
        public static string CategoryDeleted = "Kategori silindi";
        public static string CategoryUpdated = "Kategori güncellendi";

        public static string AuthorizationDenied = "Yetkiniz yok";
    }
}