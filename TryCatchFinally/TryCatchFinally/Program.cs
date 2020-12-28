using System;

namespace TryCatchFinally
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number!");
            string userInput = Console.ReadLine();

            try
            {
                int newUserINput = int.Parse(userInput);
            }
            catch (FormatException)
            {
                Console.WriteLine("Format exception, please enter the correct type next time");

            }
            catch (OverflowException)
            {
                Console.WriteLine("Overflow exception, please enter an integer within the bounds of the datatype");
            } finally
            {
                Console.WriteLine("This is called anyways!");
            }

            int num1 = 5;
            int num2 = 0;

            try
            {
                int result = num1 / num2;
            } catch (DivideByZeroException)
            {
                Console.WriteLine("Can't divide by zero");
            } finally
            {
                Console.WriteLine("Just testing finally");
            }
        }
    }
}
