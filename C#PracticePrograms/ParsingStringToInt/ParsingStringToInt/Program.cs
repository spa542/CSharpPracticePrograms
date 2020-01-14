using System;

namespace ParsingStringToInt
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString = "15";
            string mySecondString = "13";
            int result = Int32.Parse(myString) + Int32.Parse(mySecondString);
            Console.WriteLine("The result is " + result);
            string newString = "12.345";
            double newResult = Double.Parse(newString);
            Console.WriteLine("The double that is parsed is " + newResult);
            WriteSomething();
            Console.Read();
        }

        public static void WriteSomething()
        {
            Console.WriteLine("I am called from a method");
            Console.Read();
        }
    }
}
