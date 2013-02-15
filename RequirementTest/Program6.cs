using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Diagnostics;
using System.Threading;

namespace QuestionsTest
{
	class Programx
	{
		const int N = 10;
		static void Main(string[] args)
		{
			//string[] line1 = "6 7".Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
			string[] line1 = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
			int n = int.Parse(line1[0]);
			int m = int.Parse(line1[1]);

			for (int i = 0; i < m; i++)
			{
				string[] line = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
			}

			Thread.Sleep(10000);

			Console.Write(1000);

		}
	}

}
