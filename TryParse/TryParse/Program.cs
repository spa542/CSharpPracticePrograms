using System;

namespace TryParse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the temperature today?");
            string temperature = Console.ReadLine();

            int number;
            if (int.TryParse(temperature, out number))
            {
                Console.WriteLine(number);
            } else
            {
                Console.WriteLine("Value entered was no number. 0 set as temperature");
            }
        }
    }
}
