using System.Collections.Generic;

namespace Fibonachi
{
	public interface ICache<T>
	{
		T Get(string forUser, T obj);
		void Set(string forUser, T obj);
	}
}
