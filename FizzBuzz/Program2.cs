using System;
using System.Linq;
using System.Net;
namespace FizzBuzz
{
	class Program2
	{
		static void Main(string[] args)
		{
			//Enumerable.Range(1, 100).ToList().ForEach(x =>
			//{
			//    Console.WriteLine(x % 3 == 0 && x % 5 == 0 ? "FizzBuzz" : x % 3 == 0 ?
			//        "Fizz" :
			//        (x % 5 == 0 ? "Buzz" : x + ""));
			//});

			for(int i=0;i<100;f(++i));

		//    Func<string,bool> f = s =>
		//{
		//    Console.Write(s);
		//    return true;
		//};
		//    int x = 1;
		//    while(x++<101)

		//    //Enumerable.Range(1, 100).ForEach(x =>
		//    {
		//        //var a = x%3==0&&f("Fizz")||(x%5==0?f("buzz"):f(x+""))||f("\n");
		//        var a = x % 3 == 0 && f("Fizz");
		//        a = x % 5 == 0 && f("Buzz") || a;
		//        a = a || f(x + "");
		//        f("\n");	
		//    }//);

		//    //from x in Enumerable.Range(1, 100)
			//    select x%3&&f("Fizz")||x%5&&f("Fizz")

			//var q=Enumerable.Range(1, 100);
			//foreach (int x in q)
			//{
			//    if
			//}

			//Console.WriteLine(new WebClient().DownloadString(@"http://cdn.hackerrank.com/fizzbuzz.txt"));
		}
		static void f(int i)
		{
			string s=((i % 3 != 0 ? "" : "Fizz") + (i % 5 != 0 ? "" : "Buzz"));
			if (s == "") s = i + "";
			Console.WriteLine(s);
		}
	}
}
