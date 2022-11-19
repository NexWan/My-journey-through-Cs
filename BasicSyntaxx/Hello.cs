using System;

namespace BasicSyntaxx
{
    public class Hello
    {
        public static void Main()
        {
            string name;
            name = Console.ReadLine();
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hello {0} your age is: {1}!",name,age);
        }
    }
}