using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Fibonachi
{
	class Calculator<T> where T:ICalculate<T>
	{
		private ICache<T> _cache;

		public Calculator(ICache<T> cache)
		{
			_cache = cache;
		}

		public T Calculate(T arg)
		{
			var user = Thread.CurrentPrincipal.Identity.Name;
			var cacheResults = _cache.Get(user, arg);

			if (cacheResults == null)
			{
				var result = arg.Calculate();
				_cache.Set(user, result);
				return result;
			}

			var newResult = arg.CalculateWithPreviousResult(cacheResults);
			_cache.Set(user, newResult);
			return newResult;
		}
	}
}