using NorthwindLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace CachingSolutionsSamples
{
	public class Manager<T> where T:class
	{
		private ICache<T> cache;

		public Manager(ICache<T> cache)
		{
			this.cache = cache;
		}

		public IEnumerable<T> Get()
		{
			Console.WriteLine("Get Categories");

			var user = Thread.CurrentPrincipal.Identity.Name;
			var result = cache.Get(user);

			if (result == null)
			{
				Console.WriteLine("From DB");

				using (var dbContext = new Northwind())
				{
					dbContext.Configuration.LazyLoadingEnabled = false;
					dbContext.Configuration.ProxyCreationEnabled = false;
					result = dbContext.Set<T>().ToList();
					cache.Set(user, result);
				}
			}

			return result;
		}
	}
}
