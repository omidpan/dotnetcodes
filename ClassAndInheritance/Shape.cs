using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndInheritance
{
    public abstract class Shape
    {
        protected int _side;
        public abstract int Side { get; set; }

    }
   public  class Square : Shape
    {
        // Side property is required to avoid a compile-time error.
        public override int Side
        {
            get => _side;
            set => _side = value;
        }
       
    }

    }
