﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Diagnostics;

namespace QuestionsTest
{
	class Program3
	{
		const int N = 10;
		static List<Condition> condition = new List<Condition>();
		static void Main3(string[] args)
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

			int r = 1;
			for (int i = 0; i < n; i++)
			{
				r = r * 10;
			}

			long o=0;
			for (int i =0; i < r; i++)
			{
				if (CanPassCondition(i))
					o++;
			}

			Console.WriteLine(o.ToString("0000000000"));
			Console.WriteLine(o%1007);

			stopWatch.Stop();
			TimeSpan ts = stopWatch.Elapsed;
			Console.Write(ts);
		}
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
