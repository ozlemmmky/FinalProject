﻿using Business.Concrete;
using ConsoleUI;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

namespace ConsoleUI
{
    class ConsoleUI
    {
        //SOLID
        //Open Closed Principle : Yeni bir özellik eklenirken mevcut kodlarına dokunamazsın.
        static void Main(string[] args)
        {
            // ProductTest();
            // CategoryTest();

            ProductManager productManager = new ProductManager(new EfProductDal());
            foreach(var product in productManager.GetProductDetails())
            {
                Console.WriteLine(product.ProductName + "/" + product.CategoryName);

            }

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
            foreach (var product in productManager.GetAll())
            {
                Console.WriteLine(product.ProductName);
            }
            foreach (var product in productManager.GetAllByUnitPrice(500, 1000))
            {
                Console.WriteLine(product.ProductName);
            }
        }
    }
}

