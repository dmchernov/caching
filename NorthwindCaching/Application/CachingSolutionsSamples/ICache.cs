using System.Collections.Generic;

namespace CachingSolutionsSamples
{
	public interface ICache<T>
	{
		IEnumerable<T> Get(string forUser);
		void Set(string forUser, IEnumerable<T> collection);
	}
}
