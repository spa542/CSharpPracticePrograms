﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClasses
{
    class Cube : Shape
    {
        public double Length { get; set; }

        public Cube(double length)
        {
            Name = "Cube";
            this.Length = length;
        }
        public override double Volume()
        {
            return Math.Pow(Length, 3);
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"The Cube has a length of {Length}");
        }
    }
}
