using System;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Box box = new Box();
            box.length = 3;

            box.Height = 5;
            box.Width = 5;

            box.DisplayInfo();
            Console.WriteLine("The volume is (from property) " + box.Volume);
        }
    }
}
