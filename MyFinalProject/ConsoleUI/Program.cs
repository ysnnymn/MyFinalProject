﻿using Business.Concrete;
using DataAccess.Concrete.EntityFramework;

namespace ConsoleUI;

class Program
{
    static void Main(string[] args)
    {
        //ProductTest();
        //CategoryTest();


        //ProductManager productManager = new ProductManager(new EfProductDal());
        //foreach (var item in productManager.GetProductDetails())
        //{
        //    Console.WriteLine(item.ProductName+"/"+item.CategoryName);
        //}
    }

    //private static void CategoryTest()
    //{
    //    CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
    //    foreach (var item in categoryManager.GetAll())
    //    {
    //        Console.WriteLine(item.CategoryName);
    //    }
    //}

    //private static void ProductTest()
    //{
    //    ProductManager productManager = new ProductManager(new EfProductDal());
    //    var result = productManager.GetProductDetails();
    //    if (result.Success==true)
    //    {
    //        foreach (var product in result.Data)
    //        {
    //            Console.WriteLine(product.ProductName + "/ " + product.CategoryName);
    //        }
    //    }
    //    else
    //    {
    //        Console.WriteLine(result.Message);
    //    }
        
    //}
}

