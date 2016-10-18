using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonachi
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Введите количество чисел:");

			int count;
			if (!Int32.TryParse(Console.ReadLine(), out count)) count = 10;

			var calc = new Calculator<FibonachiLine>(new MemoryCache<FibonachiLine>());

			var result = calc.Calculate(new FibonachiLine(count));

			foreach (var i in result.Line)
			{
				Console.Write($"{i} ");
			}

			Console.ReadKey();
		}
	}
}
