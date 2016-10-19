using System;

namespace Fibonachi
{
	class Program
	{
		static void Main(string[] args)
		{
			var calc = new Calculator<FibonachiLine>(new FibonachiRedisCache("localhost"));

			for (int a = 10; a <= 100; a += 10)
			{
				Console.WriteLine($"Первые {a} чисел Фибоначчи:");
				var result = calc.Calculate(new FibonachiLine(a));

				foreach (var i in result.Line)
				{
					Console.Write($"{i} ");
				}
				Console.WriteLine("\n");
			}
			//var result = calc.Calculate(new FibonachiLine(10));

			//foreach (var i in result.Line)
			//{
			//	Console.Write($"{i} ");
			//}
			//Console.WriteLine("\n--------------------");


			//result = calc.Calculate(new FibonachiLine(40));

			//foreach (var i in result.Line)
			//{
			//	Console.Write($"{i} ");
			//}
			//Console.WriteLine("\n--------------------");


			//result = calc.Calculate(new FibonachiLine(20));

			//foreach (var i in result.Line)
			//{
			//	Console.Write($"{i} ");
			//}
			//Console.WriteLine("\n--------------------");


			Console.ReadKey();
		}
	}
}
