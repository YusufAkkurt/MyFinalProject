using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;

namespace ConsoleUI
{
    // SOLID
    // Open Closed Principle = Açık Kapalılık Prensibi, Mevcuttaki kodlara dokunmuyoruz
    class Program
    {
        static void Main(string[] args)
        {
            // DTO = Data Transformation Obhject
            ProductTest();
            // IoC
            // CategoryTest();
        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());

            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine(category.CategoryName);
            }
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            foreach (var product in productManager.GetProductDetails())
            {
                Console.WriteLine(product.ProductName + " / " + product.CategoryName);
            }
        }
    }
}