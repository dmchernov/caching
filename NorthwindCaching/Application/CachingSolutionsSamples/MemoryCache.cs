using System.Collections.Generic;
using System.Runtime.Caching;

namespace CachingSolutionsSamples
{
	internal class MemoryCache<T> : ICache<T>
	{
		ObjectCache cache = MemoryCache.Default;
		string prefix  = "Cache_" + typeof(T);

		public IEnumerable<T> Get(string forUser)
		{
			return (IEnumerable<T>) cache.Get(prefix + forUser);
		}

		public void Set(string forUser, IEnumerable<T> collection)
		{
			cache.Set(prefix + forUser, collection, ObjectCache.InfiniteAbsoluteExpiration);
		}
	}
}
