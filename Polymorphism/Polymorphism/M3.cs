using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    class M3 : BMW
    {
        public M3(int hp, string color, string model) : base (hp, color, model)
        {

        }

        /*
         * Sealed so this will not work
        public override void repair()
        {
            base.repair();
        }
        */
    }
}
