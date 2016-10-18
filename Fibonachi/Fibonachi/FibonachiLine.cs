using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonachi
{
	public class FibonachiLine : ICalculate<FibonachiLine>
	{
		public List<ulong> Line { get; private set; } = new List<ulong>();
		public int Length { get; private set; }

		public FibonachiLine(int count)
		{
			Length = count;
		}

		public FibonachiLine Calculate()
		{
			if (Line.Count == Length) return this;

			for (int i = Line.Count; i < Length; i++)
			{
				if (i < 2) Line.Add(1);
				else Line.Add(Line[i-2] + Line[i-1]);
			}

			return this;
		}

		public FibonachiLine CalculateWithPreviousResult(FibonachiLine previous)
		{
			Line = previous.Line;

			return Calculate();
		}
	}
}
