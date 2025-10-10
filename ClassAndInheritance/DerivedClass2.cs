using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndInheritance
{
    internal class DerivedClass2 : BaseClassImpl
    {
        public override void FirstMethod()
        {
            Console.WriteLine("In DerivedClass First method");
        }
        public override void SecondMethod() {
            Console.WriteLine("In DerivedClass SecondMethod");
            base.SecondMethod(); //optional call to BaseClass method impl

        }
    }

}
