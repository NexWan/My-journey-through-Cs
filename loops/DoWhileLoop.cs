using System;

namespace loops
{
    public class DoWhileLoop
    {
        public static void Main()
        {
            int i = 1;
            do
            {
                Console.WriteLine("Hello {0} times", i);
            } while (i != 1);
        }
    }
}