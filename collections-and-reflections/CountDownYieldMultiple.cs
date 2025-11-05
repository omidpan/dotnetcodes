using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collections_and_reflections
{
    public class CountdownYieldMultiple : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return 2;
            yield return 1;
            yield return 0;
        }
    }
}
