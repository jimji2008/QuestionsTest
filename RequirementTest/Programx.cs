using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication81
{
	class Program
	{
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

			//foreach (var c in condition)
			//{
			//    Console.WriteLine(c);
			//}

			//
			List<int[]> rlist = new List<int[]>();

			for (int j = 0; j < 10; j++)
			{
				int[] assignments = new int[n];
				for (int i = 0; i < n; i++)
					assignments[i] = -1;
				assignments[0] = j;
				rlist.Add(assignments);
			}
			for (int j = 1; j < n; j++)
			{
				List<int[]> rlist2 = new List<int[]>(rlist.Count * 5);
				for (int k = 0; k < rlist.Count; k++)
				{
					for (int l = 0; l < 10; l++)
					{
						rlist[k][j] = l;
						if (CanPassCondition(rlist[k]))
							rlist2.Add((int[])rlist[k].Clone());
					}
				}
				rlist = rlist2;
			}

			//int f = 0;
			//foreach (var x in rlist)
			//{
			//    foreach (var y in x)
			//        Console.Write(y + ",");

			//    Console.WriteLine();
			//    if (f++ > 20) break;
			//}

			//int a = 0;
			//for (int k = 0; k < rlist.Count; k++)
			//{
			//    if (CanPassCondition(rlist[k]))
			//        a++;
			//}

			//Console.WriteLine("===========");
			//f = 0;
			//foreach (var x in rlist)
			//{
			//    foreach (var y in x)
			//        Console.Write(y + ",");

			//    Console.WriteLine();
			//    if (f++ > 50000) break;
			//}

			//Console.Write(a);
			Console.Write(rlist.Count % 1007);
		}


		private static bool CanPassCondition(int[] p)
		{
			foreach (var c in condition)
			{
				if (p[c.X] == -1 || p[c.Y] == -1)
					continue;

				if (p[c.X] > p[c.Y])
					return false;
			}
			return true;
		}
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
