using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    class BMW : Car
    {
        private string brand = "BMW";
        public string Model { get; set; }

        public BMW(int hp, string color, string model) : base(hp, color)
        {
            this.Model = model;
        }

        public BMW()
        {

        }

        public new void showDetails()
        {
            Console.WriteLine("Brand " + brand + " HP: " + HP + " color: " + Color);
        }

        public sealed override void repair()
        {
            Console.WriteLine("The BMW {0} was repaired", Model);
        }
    }
}
