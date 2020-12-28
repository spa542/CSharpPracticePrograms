using System;

namespace StringStuff
{
    // Class Names
    class Program
    {
        // Method Names
        static void Main(string[] args)
        {
            string myname = "Ryan";

            string message = "My name is " + myname;

            Console.WriteLine(myname);
            Console.WriteLine(message);
            string capsMessage = message.ToUpper();

            Console.WriteLine(capsMessage);
            float myFloat = 13.45F;
            Console.WriteLine(myFloat.ToString());
            Console.Read();
        }
    }
}
