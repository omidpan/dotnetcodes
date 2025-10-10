using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndInheritance
{
    public partial class PartialEmployee
    {
        partial void GenerateEmployeeId()
        {
            Random r=new Random();
            this.EmpID = r.Next();
        }

    }
}
