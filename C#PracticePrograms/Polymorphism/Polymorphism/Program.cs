using System;
using System.Collections.Generic;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            var cars = new List<Car>
            {
                new BMW(200, "blue", "A4"),
                new BMW(250, "red", "M3")
            };

            foreach(var car in cars)
            {
                car.repair();
            }

            // Because its a Car
            Car bmwZ3 = new BMW(200, "black", "Z3");
            bmwZ3.showDetails();

            // Because its a new keyword on showDetails()
            BMW bmwM5 = new BMW(330, "white", "M%");
            bmwM5.showDetails();

            Car carB = (Car)bmwM5;
            carB.showDetails();

            M3 myM3 = new M3(260, "red", "M3 Super Turbo");
            myM3.repair();
            Console.Read();
        }
    }
}
