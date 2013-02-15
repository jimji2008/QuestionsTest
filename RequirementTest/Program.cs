using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Diagnostics;

namespace QuestionsTest
{
	class Program
	{
		const int N = 10;
		static List<Condition> condition = new List<Condition>();
		static void Mainx(string[] args)
		{
			//string[] line1 = "6 7".Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
			string[] line1 = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
			int n = int.Parse(line1[0]);
			int m = int.Parse(line1[1]);

			for (int i = 0; i < m; i++)
			{
				string[] line = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
				condition.Add(new Condition()
				{
					X = int.Parse(line[0]),
					Y = int.Parse(line[1])
				});
			}

			Stopwatch stopWatch = Stopwatch.StartNew();

			//int s1 = 0;
			//for (int j = 1; j < 11; j++)
			//{
			//    int s = 0;
			//    for (int i = 0; i < j; i++)
			//    {
			//        s++;
			//    }
			//    s1 = s1 + s * j;
			//}
			//Console.WriteLine(s1);

			//int s2 = 0;
			//for (int k = 0; k < 10; k++)
			//{
			//    int s1 = 0;
			//    for (int j = 0; j < k; j++)
			//    {
			//        int s = 0;
			//        for (int i = 0; i < j; i++)
			//        {
			//            s++;
			//        }
			//        s1 = s1 + s;
			//    }
			//    s2=s2+s1;
			//}
			//Console.WriteLine(s2);

			//Console.WriteLine(o.ToString("0000000000"));
			//Console.WriteLine(o%1007);

			//int r = F(1, 0)*F(1,0)*F(2,0);
			int r = F(6);
			Console.WriteLine(r);
			Console.WriteLine(r%1007);


			stopWatch.Stop();
			TimeSpan ts = stopWatch.Elapsed;
			Console.Write(ts);
		}


		static int F(int index)
		{
			int r = 0;
			for (int i = 0; i < 10; i++)
			{
				r += F(5, i);
			}

			return r;

		}

		static int F(int index, int x)
		{
			if(index > 0)
			{
				int r = 1;
				foreach (var c in condition)
				{
					int r2=0;
					if (c.X == index)
					{
						Console.Write(r2);
						for (int i = 0; i < f[x]; i++)
						{
							r2 += F(index - 1, i);
						}
					}
					else {
						return F(index - 1); ;
					}
					r *= r2;
				}

				return r;
			}
			return f[x];
		}
		static int[] f = new int[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };



		private static bool CanPassCondition(byte[] p)
		{
			foreach (var c in condition)
			{
				if (p[c.X] == byte.MaxValue || p[c.Y] == byte.MaxValue)
					continue;

				if (p[c.X] > p[c.Y])
					return false;
			}
			return true;
		}
		private static bool CanPassCondition(long l)
		{
			string str = l.ToString("000000");
			foreach (var c in condition)
			{
				int a = int.Parse(str[c.X].ToString());
				int b = int.Parse(str[c.Y].ToString());
				if (a>b)
					return false;
			}
			return true;
		}

		class Condition
		{
			public int X;
			public int Y;

			public override string ToString()
			{
				return string.Format("x:{0}, y:{1}", X, Y);
			}
		}
	}

}
