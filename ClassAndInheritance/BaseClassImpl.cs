using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndInheritance
{
    public abstract class BaseClassImpl:ISampleInterface
    {
        public abstract void FirstMethod();
        public virtual void SecondMethod()
        {
            Console.WriteLine("In the BaseClassImpl BaseMethod2 virtual");
        }
    }
}
