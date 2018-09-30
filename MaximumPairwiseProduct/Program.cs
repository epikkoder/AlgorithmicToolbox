using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumPairwiseProduct
{
	class Program
	{
		static void Main(string[] args)
		{
			int product = MaxPairwiseProductNaive();

			Console.WriteLine("Maximum product is " + product);
		}

		public static int MaxPairwiseProductNaive()
		{
			int inputCount = Convert.ToInt32(Console.ReadLine());
			int[] numbers = new int[inputCount];
			int product = 0;

			for (int i = 0; i < inputCount; i++)
			{
				numbers[i] = Convert.ToInt32(Console.ReadLine());
			}

			if (numbers.Length > 0)
			{
				for (int i = 0; i < numbers.Length; i++)
				{
					for (int j = i + 1; j < numbers.Length; j++)
					{
						if (numbers[i] * numbers[j] > product)
						{
							product = numbers[i] * numbers[j];
						}
					}
				}
			}

			return product;
		}
	}
}
