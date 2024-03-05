﻿using System;
using System.Linq.Expressions;
using System.Runtime.ConstrainedExecution;
using DataAccess.Abstract;
using Core.DataAccess.EntityFramework;

using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, NorthwindContext>, IProductDal
    {
        public List<ProductDetailDto> GetProductDetails()
        {
            using (NorthwindContext context=new NorthwindContext())
            {
                var result = from p in context.Products
                             join c in context.Categories
                             on p.CategoryId equals c.CategoryId
                             select new ProductDetailDto
                             {
                                 ProductId = p.ProductId,
                                 ProductName = p.ProductName,
                                 CategoryName = c.CategoryName,
                                 UnitsInStock = p.UnitsInStock

                             };
                return result.ToList();
                           
            }
        }
    }
}

