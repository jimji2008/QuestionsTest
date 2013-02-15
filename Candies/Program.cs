using System;
using System.Collections.Generic;
using System.Text;

namespace Candies
{
	class Program
	{
		static void Mainx(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			int[] ratings = new int[n];
			for (int i = 0; i < n; i++)
			{
				ratings[i] = int.Parse(Console.ReadLine());
			}

			int num = 0;
			int lastCandiesNum = 0;
			for (int i = 0; i < n; i++)
			{
				int candiesNum = 0;
				if (i == 0)
				{
					candiesNum = 1;
				}
				else
				{
					if (ratings[i] > ratings[i - 1])
					{
						candiesNum = lastCandiesNum + 1;
					}
					else
					{
						candiesNum = 1;
					}
				}
				num += candiesNum;
				lastCandiesNum = candiesNum;
			}

			Console.Write(num);
		}
	}
}
