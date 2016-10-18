using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
			return arg.Calculate();
		}
	}
}
