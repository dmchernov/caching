using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Caching;
using System.Text;
using System.Threading.Tasks;

namespace Fibonachi
{
	class MemoryCache<T> : ICache<T>
	{
		ObjectCache cache = System.Runtime.Caching.MemoryCache.Default;
		string prefix = "Cache_" + typeof(T);

		public IDictionary<string, T> Get(string forUser)
		{
			return cache.GetValues(prefix + forUser) as IDictionary<string,T>;
		}

		public void Set(string forUser, T obj)
		{
			cache.Set(prefix + forUser, obj, ObjectCache.InfiniteAbsoluteExpiration);
		}
	}
}
