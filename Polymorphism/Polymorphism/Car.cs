using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    class Car
    {
        public int HP { get; set; }
        public string Color { get; set; }

        public Car(int hp, string color)
        {
            this.HP = hp;
            this.Color = color;
        }

        public Car()
        {

        }

        public void showDetails()
        {
            Console.WriteLine("HP: " + HP + " color:" + Color);
        }

        public virtual void repair()
        {
            Console.WriteLine("Car was repaired");
        }
    }
}
