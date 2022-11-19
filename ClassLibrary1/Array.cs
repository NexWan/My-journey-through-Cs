using System;

namespace ClassLibrary1
{
    public class Array
    {
        public static void Main()
        {
            string[] x;
            x = new[] {"Leo", "Johnny", "Kierna"};
            Console.WriteLine(x.Length);
            for (int i = 0; i < x.Length; i++)
            {
                Console.WriteLine(x[i]);
            }
        }
    }
}