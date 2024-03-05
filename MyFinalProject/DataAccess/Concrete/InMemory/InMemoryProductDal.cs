using System;using System.Linq.Expressions;
using DataAccess.Abstract;using Entities.Concrete;using Entities.DTOs;

namespace DataAccess.Concrete.InMemory{	public class InMemoryProductDal:IProductDal	{		List<Product> _products;				public InMemoryProductDal()		{			_products = new List<Product>()			{new Product{ ProductId=1, CategoryId=1, ProductName="Bardak", UnitPrice=15, UnitsInStock=10 },			new Product{ ProductId=2, CategoryId=1, ProductName="Kalem", UnitPrice=10, UnitsInStock=6 },			new Product{ ProductId=3, CategoryId=2, ProductName="Kamera", UnitPrice=5, UnitsInStock=4 }			};		}		public void Add(Product product)		{			_products.Add(product);		}		public void Delete(Product product)		{			Product productToDelete = _products.SingleOrDefault(p => p.ProductId == product.ProductId);			//foreach (var p in _products)			// {			//  if (product.ProductId==p.ProductId)			// {			//  productToDelete = p;			// }			// }			_products.Remove(productToDelete);		}

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()		{			return _products;		}

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByCategory(int categoryId)		{			return _products.Where(p => p.CategoryId == categoryId).ToList();		}

        public List<ProductDetailDto> GetProductDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)		{			Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);			productToUpdate.ProductName = product.ProductName;			productToUpdate.CategoryId = product.CategoryId;			productToUpdate.UnitPrice = product.UnitPrice;			productToUpdate.UnitsInStock = product.UnitsInStock;		}	}}