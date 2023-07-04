using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sorting_algorithms.Bubble
{
    public static class Sort
    {
        public static int[] Ascending(int[] inAry)
        {
            bool swapped;
            int swapValue;
            for (int i = 0; i < inAry.Length - 1; i++)
            {
                swapped = false;
                //The inner loop iterated over the entire loop, minus the number of tiems the outer loop as run.
                //This is because the highest numbers should bubble to top - i position each time, resulting in
                //The list being ordered smallest to largest.
                for (int j = 0; j < inAry.Length - 1 - i; j++)
                {
                    if (inAry[j] > inAry[j + 1])
                    {
                        swapped = true;
                        swapValue = inAry[j];
                        inAry[j] = inAry[j + 1];
                        inAry[j + 1] = swapValue;
                    }
                }
                if (swapped == false) break;

            }
            return inAry;
        }
    }
}
