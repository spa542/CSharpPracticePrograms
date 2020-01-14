using System;

namespace ClassesStuff
{
    class Program
    {
        static void Main(string[] args)
        {
            Human ryan = new Human(2,2);

            Console.WriteLine("Hi my name is ryan!");
            Console.WriteLine("I have " + ryan.getArms() + " arms");
            Console.WriteLine("I have " + ryan.getLegs() + " legs");
            Console.Read();
        }
    }
}
