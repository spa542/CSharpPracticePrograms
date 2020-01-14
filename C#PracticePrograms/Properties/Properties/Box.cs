using System;
using System.Collections.Generic;
using System.Text;

namespace Properties
{
    class Box
    {
        // member variables
        public int length;
        private int height;
        // public int width;
        public int volume;

        // Does not need a member variable, meant when no addtional logic is needed
        public int Width { get; set; }

        public int Volume
        {
            get
            {
                return this.length * Height * Width;
            }
        }
        public int Height
        {
            get
            {
                return height;
            }
            set
            {
                if (value < 0)
                {
                    height = -value;
                } else
                    height = value;
            }
        }
        public void setLength(int length)
        {
            if (length < 0)
            {
                throw new Exception("Length should be higher than 0");
            }
            this.length = length;
        }
        public void DisplayInfo()
        {
            Console.WriteLine("Length is {0}, Height is {1}, Width is {2}, so the volume is {3}", 
                length, height, Width, volume = length * height * Width);
        }
    }
}
