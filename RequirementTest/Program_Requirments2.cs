using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Diagnostics;

namespace QuestionsTest
{
	class Program2
	{
		const byte N = 10;
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
			Stopwatch stopWatch = Stopwatch.StartNew();


			List<byte[]> rlist = new List<byte[]>();


			//Console.WriteLine('1');
			for (byte j = 0; j < N; j++)
			{
				byte[] assignments = new byte[n];
				for (int i = 0; i < n; i++)
					assignments[i] = byte.MaxValue;
				assignments[0] = j;
				rlist.Add(assignments);
			}
			//Console.WriteLine('2');

			foreach (var c in condition)
			{
				if (rlist[0][c.X] == byte.MaxValue)
				{
					//Console.WriteLine("2.1");
					List<byte[]> rlist2 = new List<byte[]>(rlist.Count);
					for (int k = 0; k < rlist.Count; k++)
					{
						byte[] t = rlist[k];
						byte yn = t[c.Y] == byte.MaxValue ? N : t[c.Y];
						for (byte l = 0; l <= yn; l++)
						{
							t[c.X] = l;
							if (CanPassCondition(t))
								rlist2.Add((byte[])t.Clone());
						}
					}
					rlist = rlist2;
				}
				//Console.WriteLine("x");
				if (rlist[0][c.Y] == byte.MaxValue)
				{
					//Console.WriteLine("2.2");
					List<byte[]> rlist2 = new List<byte[]>(rlist.Count);
					for (int k = 0; k < rlist.Count; k++)
					{
						byte[] t = rlist[k];
						byte xn = t[c.X] == byte.MaxValue ? (byte)0 : t[c.X];
						//Console.Write("y");
						//Console.WriteLine(xn);
						for (int l = 9; l >= xn; l--)
						{
							//Console.Write(l+",");
							t[c.Y] =(byte) l;
							if (CanPassCondition(t))
								rlist2.Add((byte[])t.Clone());
						}
					}

					rlist = rlist2;
				}

				//if (rlist[0][c.X] != byte.MaxValue && rlist[0][c.Y] == byte.MaxValue)
				//{
				//    //Console.WriteLine("2.2");
				//    List<byte[]> rlist2 = new List<byte[]>(rlist.Count);
				//    for (int k = 0; k < rlist.Count; k++)
				//    {
				//        if (CanPassCondition(rlist[k]))
				//            rlist2.Add((byte[])rlist[k].Clone());
				//    }

				//    rlist = rlist2;
				//}
			}

			//Console.WriteLine('3');

			List<byte[]> rlist3 = new List<byte[]>(rlist.Count);
			for (int k = 0; k < rlist.Count; k++)
			{
				if (CanPassCondition(rlist[k]))
					rlist3.Add((byte[])rlist[k].Clone());
			}

			rlist = rlist3;

			
			long r = rlist.Count;
			for (int j = 1; j < n; j++)
			{

				if (rlist[0][j] != byte.MaxValue) continue;
				r = r * N;
				//Console.WriteLine(r);
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
			//Console.Write(r+", ");
			Console.Write(r % 1007);

			TimeSpan ts = stopWatch.Elapsed;
			//Console.Write("\n"+ts);
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
