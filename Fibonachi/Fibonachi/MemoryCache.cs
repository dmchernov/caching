using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Caching;
using System.Text;
using System.Threading.Tasks;

namespace Fibonachi
{
	class FibonachiMemoryCache : ICache<FibonachiLine>
	{
		ObjectCache cache = System.Runtime.Caching.MemoryCache.Default;
		string prefix = "Cache_" + typeof(FibonachiLine);

		public FibonachiLine Get(string forUser, FibonachiLine obj)
		{
			for (int i = obj.Length; i > 0; i--)
			{
				var result = cache.Get(prefix + obj.Length + forUser) as FibonachiLine;
				if(result == null) continue;
				return result;
			}
			return null;
		}

		public void Set(string forUser, FibonachiLine obj)
		{
			cache.Set(prefix + obj.Length + forUser, obj, ObjectCache.InfiniteAbsoluteExpiration);
		}
	}
}
