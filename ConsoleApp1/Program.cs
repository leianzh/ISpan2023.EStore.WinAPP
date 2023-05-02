using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string v1 = Demo.Get<int>(55);
			string v11 = Demo.Get(55);//可以不寫<>
			string v2 = Demo.Get<string>("abc");
			string v3 = Demo.Get<DateTime>(DateTime.Today);
			Console.WriteLine(v1);
			Console.WriteLine(v2);
			Console.WriteLine(v3);

			Func<int,bool>funcB = num =>num%2 == 0;
			bool isEven = Demo.Parse<int, bool>(99, funcB);
			Console.WriteLine(isEven);

			Func<string,DateTime>funcD = value =>DateTime.Parse(value);
			DateTime dt = Demo.Parse<string, DateTime>("2023/1/1", funcD);
			Console.WriteLine(dt);
		}
	}
	public class Demo
	{
		public static T2 Parse<T,T2>(T value, Func<T, T2> func) 
		{
			return func(value);
		}
		public static string Get<T>(T value) 
		{
			return value.ToString();
		}
	}
}
