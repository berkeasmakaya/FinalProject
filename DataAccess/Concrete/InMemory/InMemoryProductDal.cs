﻿using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
	public class InMemoryProductDal : IProductDal
	{
		List<Product> _products;

		public InMemoryProductDal()
		{
			_products = new List<Product> {
				new Product{ProductId=1, CategoryId=1, ProductName="Keyboard", UnitPrice=450, UnitsInStock=30},
				new Product{ProductId=2, CategoryId=1, ProductName="Display", UnitPrice=500, UnitsInStock=10},
				new Product{ProductId=3, CategoryId=2, ProductName="SmartPhone", UnitPrice=20000, UnitsInStock=20},
				new Product{ProductId=4, CategoryId=2, ProductName="Computer", UnitPrice=30000, UnitsInStock=15},
				new Product{ProductId=5, CategoryId=2, ProductName="Mouse", UnitPrice=400, UnitsInStock=100}
			};
		}

		public void Add(Product product)
		{
			_products.Add(product);
		}

		public void Delete(Product product)
		{
			//LINQ - Language Integrated Query
			Product productToDelete = _products.SingleOrDefault(p => p.ProductId == product.ProductId); 
			_products.Remove(productToDelete);
		}

		public List<Product> GetAll()
		{
			return _products;
		}

		public List<Product> GetAllByCategory(int categoryId)
		{
			return _products.Where(p=>p.CategoryId == categoryId).ToList();
		}

		public void Update(Product product)
		{
			Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
			productToUpdate.ProductName= product.ProductName;
			productToUpdate.CategoryId= product.CategoryId;
			productToUpdate.UnitPrice= product.UnitPrice;
			productToUpdate.UnitsInStock= product.UnitsInStock;
		}
	}
}
