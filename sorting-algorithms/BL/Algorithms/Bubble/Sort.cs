using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sorting_algorithms.BL.Algorithms.Bubble
{
    /// <summary>
    /// The bubble sort works through the use of a nested loop.  The outer loop iterates through each item in the array (n) to
    /// use the inner loop to iterate through n - i items in the array, starting at the left.  As the inner loop runs it checks
    /// if the current item in the array is greater (asending order) or smaller (descending order) than the next item in the array.
    /// If the comparison operator is true these values are swapped.  This continues until the end of the run in the inner loop,
    /// this will put the largest (ascending) or smallest (descending) number in the current iteration in the last place to the
    /// right on each run.  As the name suggests, the largers number (ascending order) or smallest (descending order) will 
    /// bubble up to the top (right) of the array for each run.
    /// </summary>
    public class Sort
    {
        /// <summary>
        /// Bubble sort in ascending order
        /// </summary>
        /// <param name="inAry"></param>
        /// <returns></returns>
        public void Ascending(int[] ary)
        {
            bool swapped;
            int swapValue;
            for (int i = 0; i < ary.Length - 1; i++)
            {
                swapped = false;
                for (int j = 0; j < ary.Length - 1 - i; j++)
                {
                    if (ary[j] > ary[j + 1])
                    {
                        swapped = true;
                        swapValue = ary[j];
                        ary[j] = ary[j + 1];
                        ary[j + 1] = swapValue;
                    }
                }
                if (swapped == false) break;
            }

            foreach (int i in ary) Console.Write(i.ToString() + ", ");
            Console.WriteLine();
        }

        /// <summary>
        /// Bubble sort in descending order
        /// </summary>
        /// <param name="inAry"></param>
        /// <returns></returns>
        public void Descending(int[] ary)
        {
            bool swapped;
            int swapValue;
            for (int i = 0; i < ary.Length - 1; i++)
            {
                swapped = false;
                for (int j = 0; j < ary.Length - 1 - i; j++)
                {
                    if (ary[j] < ary[j + 1])
                    {
                        swapped = true;
                        swapValue = ary[j];
                        ary[j] = ary[j + 1];
                        ary[j + 1] = swapValue;
                    }
                }
                if (swapped == false) break;
            }

            foreach (int i in ary) Console.Write(i.ToString() + ", ");
            Console.WriteLine();
        }
    }
}
