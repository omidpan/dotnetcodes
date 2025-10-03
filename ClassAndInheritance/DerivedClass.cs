using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndInheritance
{
    internal class DerivedClass:BaseClass
    {
        //look at override keyword
        public override void AbstractMethod()
        {
            _x++;
            _y++;
        }

        public void Display()
        {
            Console.WriteLine($"X={_x}, Y={_y}");
        }

        internal int GetX()
        {
            return _x;
        }

        internal int GetY()
        {
            return _y;
        }
    }
   
}
