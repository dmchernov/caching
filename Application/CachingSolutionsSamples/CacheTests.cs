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
			var categoryManager = new Manager<Category>(new MemoryCache<Category>());

			for (var i = 0; i < 10; i++)
			{
				Console.WriteLine(categoryManager.Get().Count());
				Thread.Sleep(100);
			}
		}

		[TestMethod]
		public void EmployeesMemoryCacheTest()
		{
			var categoryManager = new Manager<Employee>(new MemoryCache<Employee>());

			for (var i = 0; i < 10; i++)
			{
				Console.WriteLine(categoryManager.Get().Count());
				Thread.Sleep(100);
			}
		}

		[TestMethod]
		public void CategoriesRedisCacheTest()
		{
			var categoryManager = new Manager<Category>(new RedisCache<Category>("localhost"));

			for (var i = 0; i < 10; i++)
			{
				Console.WriteLine(categoryManager.Get().Count());
				Thread.Sleep(100);
			}
		}
	}
}
