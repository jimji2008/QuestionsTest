using System;
using System.Linq;
using System.Net;
namespace FizzBuzz
{
	class Program
	{
		static void Mainx(string[] args)
		{
			int x = 0;
			while (x++ < 100)
			{
				bool b = false;
				if (x % 3 == 0)
				{
					Console.Write("Fizz");
					b = true;
				} 
				if (x % 5 == 0)
				{
					Console.Write("Buzz");
					b = true;
				}
				if (!b)
					Console.Write(x.ToString());
				Console.WriteLine();
			}

			//Console.WriteLine(new WebClient().DownloadString(@"http://cdn.hackerrank.com/fizzbuzz.txt"));
		}
		//static bool f(string s)
		//{
		//    Console.Write(s);
		//    return true;
		//}
	}
}
