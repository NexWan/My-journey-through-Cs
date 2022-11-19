using System;

namespace loops {
	public class WhileLoop {
		public static void Main(string[] args)
		{
			int i = 1;
			while (i <= 10)
			{
				Console.WriteLine("Hello {0} times",i);
				i++;
			}
		}
	}
}