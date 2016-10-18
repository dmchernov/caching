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

			var calc = new Calculator<FibonachiLine>(new FibonachiMemoryCache());

			for (int a = 10; a <= 100; a+=10)
			{
				var result = calc.Calculate(new FibonachiLine(a));

				foreach (var i in result.Line)
				{
					Console.Write($"{i} ");
				}
				Console.WriteLine("\n--------------------");
			}

			Console.ReadKey();
		}
	}
}
