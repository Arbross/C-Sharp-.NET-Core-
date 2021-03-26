using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Task_IEnumerator
{
    class Fibonachi : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            uint one = 0, two = 1;
            yield return one;
            while (one + two <= 100)
            {
                if (one > two)
                {
                    two = one + two;
                    yield return two;
                }
                else
                {
                    one = two + one;
                    yield return one;
                }
            }
        }
    }
}
