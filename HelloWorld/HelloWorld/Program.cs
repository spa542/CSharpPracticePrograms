using System;

namespace HelloWorld
{
    class Program
    {
        ///  Hello World Program
        ///  Ryan Rosiak
        ///  Beginner C#
        ///  12/13/19
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello Ryan");
            
            int a, b;
            a = 2;
            b = 5;
            Console.WriteLine(addItem(a, b)); // Just add numbers for test
        }


        public static int addItem(int a, int b)
        {
            return a + b;
        }
    }
}
