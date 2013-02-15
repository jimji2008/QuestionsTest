using System;
using System.Collections.Generic;
using System.Text;

namespace Candies
{
	class Program2
	{
		static Child[] children = null;
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			int[] ratings = new int[n];
			for (int i = 0; i < n; i++)
			{
				ratings[i] = int.Parse(Console.ReadLine());
			}

			children = new Child[n];
			//children[0] = new Child() { candiesNum = 1 };
			//children[n - 1] = new Child() { candiesNum = 1 };

			// prepare
			for (int i = 0; i < n; i++)
			{
				children[i] = new Child();
				if (i == 0)
				{
					if (ratings[i] > ratings[i + 1])
					{
						children[i].RightInx = i + 1;
						children[i].greaterThanRight = true;
					}
					else
					{
						children[i].candiesNum = 1;
					}
				}
				else if (i == n - 1)
				{
					if (ratings[i] > ratings[i - 1])
					{
						children[i].LeftInx = i - 1;
						children[i].greaterThanLeft = true;
					}
					else
					{
						children[i].candiesNum = 1;
					}
				}
				else
				{
					if (ratings[i] <= ratings[i - 1] && ratings[i] <= ratings[i + 1])
					{
						children[i].candiesNum = 1;
					}
					if (ratings[i] > ratings[i - 1] && ratings[i] > ratings[i + 1])
					{
						children[i].LeftInx = i - 1;
						children[i].RightInx = i + 1;
						children[i].greaterThanLeft = true;
						children[i].greaterThanRight = true;
					}
					else if (ratings[i] > ratings[i - 1])
					{
						children[i].LeftInx = i - 1;
						children[i].greaterThanLeft = true;
					}
					else if (ratings[i] > ratings[i + 1])
					{
						children[i].RightInx = i + 1;
						children[i].greaterThanRight = true;
					}
				}
			}

			// count
			int num = 0;
			for (int i = 0; i < n; i++)
			{
				//Console.Write(children[i].ComputeCandiesNum()+",");
				num += children[i].ComputeCandiesNum();
			}

			Console.Write(num);
		}

		class Child
		{
			//public bool HaveCandies()
			//{
			//    return candiesNum != int.MaxValue;
			//}

			public int candiesNum = int.MaxValue;

			public bool greaterThanLeft = false;
			public bool greaterThanRight = false;
			public int LeftInx = int.MaxValue;
			public int RightInx = int.MaxValue;
			public int ComputeCandiesNum()
			{
				if (candiesNum != int.MaxValue)
					return candiesNum;

				if (greaterThanLeft && greaterThanRight)
				{
					candiesNum = Math.Max(children[LeftInx].ComputeCandiesNum() + 1,
						children[RightInx].ComputeCandiesNum() + 1);
					return candiesNum;
				}
				else if (greaterThanLeft)
				{
					candiesNum = children[LeftInx].ComputeCandiesNum() + 1;
					return candiesNum;
				}
				else if (greaterThanRight)
				{
					candiesNum = children[RightInx].ComputeCandiesNum() + 1;
					return candiesNum;
				}
				else 
				{
					candiesNum = 1;
					return candiesNum;
				}

			}
		}
	}
}
