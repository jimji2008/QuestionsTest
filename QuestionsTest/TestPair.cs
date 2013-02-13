using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication26
{
	class TestPair
	{
		public void Do()
		{
			try
			{
				//string line1 = Console.ReadLine();
				//string line2 = Console.ReadLine();

				//string line1 = "3 1";
				//string line2 = "1 2 3";

				string line1 = "5 2";
				string line2 = "1 5 3 4 2";

				var arr = (from nstr in line1.Split(new char[] { ' ' })
						   select int.Parse(nstr)).ToArray();

				if (arr.Length != 2)
					throw new ArgumentException();

				int n = arr[0];
				int k = arr[1];

				var list = (from nstr in line2.Split(new char[] { ' ' })
							select int.Parse(nstr)).ToList();

				if (list.Count != n)
					throw new ArgumentException();


				var list2 = (from x in list
							 select x + k);

				int result = list.Intersect(list2).Count();

				//int result = Do2(n, k, list);

				Console.Write(result);
			}
			catch (Exception ex)
			{
				Console.Write(ex);
			}
		}

		private static int Do2(int n, int k, List<int> list)
		{
			//list.ForEach(x => { Console.Write(x); });
			list.Sort();

			int m = 0;
			for (int i = 0; i < list.Count - 1; i++)
			{
				if (list[i] + k == list[i + 1])
					m++;
			}

			return m;
		}
	}
}
