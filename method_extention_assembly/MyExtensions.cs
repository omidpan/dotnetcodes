using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method_extention_assembly
{
    public static class MyExtensions
    {
        public static int WordCount(this String str)
        {
            return str
                .Split(new char[] {' ','.','?'},StringSplitOptions.RemoveEmptyEntries)
                .Length; 
        }

        public static int WordCount(this MyHelperClass myHelper)
        {
            return myHelper.Name
                .Split(new char[] { ' ', '.', '?' }, StringSplitOptions.RemoveEmptyEntries)
                .Length;
        }

    }
}
