using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesStuff
{
    class Human 
    {
        //member variable
        private int arms;
        private int legs;

        public int getArms()
        {
            return arms;
        }

        public int getLegs()
        {
            return legs;
        }

        public void setArms(int arms)
        {
            this.arms = arms;
        }

        public void setLegs(int legs)
        {
            this.legs = legs;
        }

        public Human()
        {
            this.legs = 0;
            this.arms = 1;
        }

        public Human(int a, int b)
        {
            this.legs = b;
            this.arms = a;
        }
    }
}
