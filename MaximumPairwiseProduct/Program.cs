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
			int inputCount = Convert.ToInt32(Console.ReadLine());
			int[] numbers = new int[inputCount];

			for (int i = 0; i < inputCount; i++)
			{
				numbers[i] = Convert.ToInt32(Console.ReadLine());
			}

			Console.WriteLine("Running MaxPairwiseProductNaive...");
			int product = MaxPairwiseProductNaive(numbers);
			Console.WriteLine("Maximum product is " + product);

			Console.WriteLine();

			Console.WriteLine("Running MaxPairwiseProductFast...");
			product = MaxPairwiseProductFast(numbers);
			Console.WriteLine("Maximum product is " + product);
		}

		public static int MaxPairwiseProductNaive(int[] numbers)
		{
			int product = 0;

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

		public static int MaxPairwiseProductFast(int[] numbers)
		{
			int index1 = 0;
			for (int i = 1; i < numbers.Length; i++)
			{
				if (numbers[i] > numbers[index1])
				{
					index1 = i;
				}
			}

			int index2 = 0;
			for (int i = 0; i < numbers.Length; i++)
			{
				if (numbers[i] != numbers[index1] && numbers[i] > numbers[index2])
				{
					index2 = i;
				}
			}

			return numbers[index1] * numbers[index2];
		}
	}
}
