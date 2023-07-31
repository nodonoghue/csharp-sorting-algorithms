using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sorting_algorithms.BL.Algorithms.Insertion
{
    /// <summary>
    /// Insertion Sort:  Iterate through the loop, looking at predecesors to see if larger or smaller
    /// if the conditon is met, iterate backwards through the array predacessors, moving larger or
    /// smaller items to the right until either at the beginning of the array or the predacessor no
    /// longer meets the criteria and replace the value.
    /// </summary>
    internal class Sort
    {
        /// <summary>
        /// Insertion Sort in ascending order
        /// </summary>
        /// <param name="inAry"></param>
        /// <returns></returns>
        public void Ascending(int[] iaAry)
        {
            //Iterate through the array, compare to previous item.
            //If smaller then go back until the beginning and move larger over one to the right.
            int temp;
            for (int i = 0; i < iaAry.Length; i++)
            {
                temp = iaAry[i];

                //skip the first iteration as there is no predecessors
                if (i > 0)
                {
                    //iterate back from i to 0 comparing [i] to each predecessor, stop when not smaller
                    int j = i - 1;
                    while (j >= 0 && iaAry[j] > temp)
                    {
                        iaAry[j + 1] = iaAry[j];
                        j--;
                    }
                    iaAry[j + 1] = temp;
                }
            }
            foreach (int i in iaAry) Console.Write(i.ToString() + ", ");
            Console.WriteLine();
        }

        /// <summary>
        /// Insertion sort in descending order
        /// </summary>
        /// <param name="inAry"></param>
        /// <returns></returns>
        public void Descending(int[] idAry)
        {
            //Iterate through the array, compare to previous item.
            //If larger then go back until the beginning and move smaller over one to the right.
            int temp;
            for (int i = 0; i < idAry.Length; i++)
            {
                temp = idAry[i];

                //skip the first iteration as there is no predecessors
                if (i > 0)
                {
                    //iterate back from i to 0 comparing [i] to each predecessor, stop when not larger
                    int j = i - 1;
                    while (j >= 0 && idAry[j] < temp)
                    {
                        idAry[j + 1] = idAry[j];
                        j--;
                    }
                    idAry[j + 1] = temp;
                }
            }
            foreach (int i in idAry) Console.Write(i.ToString() + ", ");
            Console.WriteLine();
        }
    }
}
