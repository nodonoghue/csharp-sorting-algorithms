using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sorting_algorithms.Insertion
{
    /// <summary>
    /// Insertion Sort:  Iterate through the loop, looking at predecesors to see if larger or smaller
    /// if the conditon is met, iterate backwards through the array predacessors, moving larger or
    /// smaller items to the right until either at the beginning of the array or the predacessor no
    /// longer meets the criteria and replace the value.
    /// </summary>
    internal class Sort : Interfaces.ISort
    {
        /// <summary>
        /// Insertion Sort in ascending order
        /// </summary>
        /// <param name="inAry"></param>
        /// <returns></returns>
        public int[] Ascending(int[] inAry)
        {
            //Iterate through the array, compare to previous item.
            //If smaller then go back until the beginning and move larger over one to the right.
            int temp;
            for (int i = 0; i< inAry.Length; i++)
            {
                temp = inAry[i];

                //skip the first iteration as there is no predecessors
                if (i > 0)
                {
                    //iterate back from i to 0 comparing [i] to each predecessor, stop when not smaller
                    int j = i-1;
                    while(j >= 0 && inAry[j] > temp)
                    {
                        inAry[j+1] = inAry[j];
                        j--;
                    }
                    inAry[j+1] = temp;
                }
            }
            return inAry;
        }

        /// <summary>
        /// Insertion sort in descending order
        /// </summary>
        /// <param name="inAry"></param>
        /// <returns></returns>
        public int[] Descending(int[] inAry)
        {
            //Iterate through the array, compare to previous item.
            //If larger then go back until the beginning and move smaller over one to the right.
            int temp;
            for (int i = 0; i < inAry.Length; i++)
            {
                temp = inAry[i];

                //skip the first iteration as there is no predecessors
                if (i > 0)
                {
                    //iterate back from i to 0 comparing [i] to each predecessor, stop when not larger
                    int j = i - 1;
                    while (j >= 0 && inAry[j] < temp)
                    {
                        inAry[j + 1] = inAry[j];
                        j--;
                    }
                    inAry[j + 1] = temp;
                }
            }
            return inAry;
        }
    }
}
