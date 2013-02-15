using System;
using System.Collections.Generic;
using System.Text;

namespace Candies
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			int[] ratings = new int[n];
			for (int i = 0; i < n; i++)
			{
				ratings[i] = int.Parse(Console.ReadLine());
			}

			int[] candies = new int[n];
			candies[0] = 1;
			candies[n-1]=1;
			for (int i = 0; i < n; i++)
			{
				ratings[i] = int.Parse(Console.ReadLine());
			}
			
			
			Console.Write(num);
		}

		class Child
		{
			public bool HaveCandies()
			{
				return candiesNum!=int.MaxValue;
			}

			public int candiesNum;

			public Func<int> Condition;
		}
	}
}
