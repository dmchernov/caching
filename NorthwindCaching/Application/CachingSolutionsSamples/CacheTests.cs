using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NorthwindLibrary;
using System.Linq;
using System.Threading;

namespace CachingSolutionsSamples
{
	[TestClass]
	public class CacheTests
	{
		[TestMethod]
		public void CategoriesMemoryCacheTest()
		{
			var manager = new EntityManager<Category>(new MemoryCache<Category>());

			for (var i = 0; i < 10; i++)
			{
				Console.WriteLine(manager.Get().Count());
				Thread.Sleep(100);
			}
		}

		[TestMethod]
		public void ProductsMemoryCacheTest()
		{
			var manager = new EntityManager<Product>(new MemoryCache<Product>());

			for (var i = 0; i < 10; i++)
			{
				Console.WriteLine(manager.Get().Count());
				Thread.Sleep(100);
			}
		}

		[TestMethod]
		public void CustomersMemoryCacheTest()
		{
			var manager = new EntityManager<Customer>(new MemoryCache<Customer>());

			for (var i = 0; i < 10; i++)
			{
				Console.WriteLine(manager.Get().FirstOrDefault()?.CompanyName);
				Thread.Sleep(100);
			}
		}

		[TestMethod]
		public void CategoriesRedisCacheTest()
		{
			var manager = new EntityManager<Category>(new RedisCache<Category>("localhost"));

			for (var i = 0; i < 10; i++)
			{
				Console.WriteLine(manager.Get().Count());
				Thread.Sleep(100);
			}
		}

		[TestMethod]
		public void ProductsRedisCacheTest()
		{
			var manager = new EntityManager<Product>(new RedisCache<Product>("localhost"));

			for (var i = 0; i < 10; i++)
			{
				Console.WriteLine(manager.Get().Count());
				Thread.Sleep(100);
			}
		}

		[TestMethod]
		public void CustomersRedisCacheTest()
		{
			var manager = new EntityManager<Customer>(new RedisCache<Customer>("localhost"));

			for (var i = 0; i < 10; i++)
			{
				Console.WriteLine(manager.Get().FirstOrDefault()?.CompanyName);
				Thread.Sleep(100);
			}
		}
	}
}
