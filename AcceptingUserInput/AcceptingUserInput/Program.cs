using System;

namespace AcceptingUserInput
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char moreInput = (char)Console.Read();
            Console.WriteLine(input);
            Console.Read();
        }
    }
}
