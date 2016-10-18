using System.Collections.Generic;

namespace Fibonachi
{
	public interface ICache<T>
	{
		IDictionary<string,T> Get(string forUser);
		void Set(string forUser, T obj);
	}
}
