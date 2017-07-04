using System;
using System.Threading;
using System.Linq;

namespace Fibonacci
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int iterations = 0;
			int counter = 1;
			int x = 0;
			int y = 1;
			int z = 1;
			Console.WriteLine ("How many entries would you like? (1-99)");
			//int iterations = Convert.ToInt32(Console.ReadLine());//
			string iterationsString = Console.ReadLine();

			int num1 = 1;
			bool res = int.TryParse(iterationsString, out num1);
			if (res == false)
			{
				Console.WriteLine ("Well, if you don't know what a number is, I'm not sure of what use I'll be...");
			}
				
			if (res == true)
			{
				iterations = Convert.ToInt32 (iterationsString);
			}
			if(iterations > 99)
			{
				Console.WriteLine("It's your funeral...");
			}

			while (counter <= iterations)
			{
				z = x + y;
				Console.Write (x);
				Console.Write ("+");
				Console.Write (y);
				Console.Write ("=");
				Console.Write (z);
				Console.WriteLine ();
				x = y;
				y = z;
				counter++;
				Thread.Sleep(333);
			}



		}
	}
}