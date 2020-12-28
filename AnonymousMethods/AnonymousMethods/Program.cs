using System;

namespace AnonymousMethods
{
    class Program
    {
        public delegate string GetTextDelegate(string name);

        public delegate double GetResultDelegate(double a, double b);
        
        static void Main(string[] args)
        {
            // Creating an anonymous method (inline method)
            GetTextDelegate getTextDelegate = delegate (string name)
            {
                return "Hello, " + name;
            };

            // Lambda Expressions!
            GetTextDelegate getHelloText = (string name) => { return "Hello, " + name; };
            // Lambda Statment!
            GetTextDelegate getGoodbyeText = (string name) =>
            {
                Console.WriteLine("I'm inside of a statement lambda");
                return "Goodbye, " + name;
            };
            // Lambda quickie!
            GetTextDelegate getWelcomeText = name => "Welcome, " + name;

            GetResultDelegate getSum = (a, b) => a + b;
            DisplayNum(getSum);

            GetResultDelegate getProduct = (a, b) => a * b;
            DisplayNum(getProduct);
            
            Console.WriteLine(getHelloText("Ryan"));
            // Display(getTextDelegate);
        }
        
        static void DisplayNum(GetResultDelegate getResultDelegate)
        {
            Console.WriteLine(getResultDelegate(3.5, 2.5));
        }

        static void Display(GetTextDelegate getTextDelegate)
        {
            Console.WriteLine(getTextDelegate("World"));
        }
    }
}
