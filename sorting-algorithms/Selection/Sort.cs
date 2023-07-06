using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace sorting_algorithms.Selection
{
    /// <summary>
    /// Seletion sort iterates throught he array to find the smallest or largest and place that value in the left-most place in the array, then iterate through again
    /// until all values have been selected and placed into the correct place in the array
    /// </summary>
    internal class Sort : Interfaces.ISort
    {
        /// <summary>
        /// Selection sort in ascending order
        /// </summary>
        /// <param name="inAry"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public int[] Ascending(int[] inAry)
        {
            int minIndex;
            int tempValue;

            for (int i = 0; i< inAry.Length - 1; i++)
            {
                minIndex = i;
                for (int j = i + 1; j < inAry.Length; j++)
                {
                    if (inAry[j] < inAry[minIndex])
                    {
                        minIndex = j;
                    }
                }
                tempValue = inAry[minIndex];
                inAry[minIndex] = inAry[i];
                inAry[i] = tempValue; 
            }
            return inAry;
        }

        /// <summary>
        /// Selection sort in descending order
        /// </summary>
        /// <param name="inAry"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public int[] Descending(int[] inAry)
        {
            int maxIndex;
            int tempValue;

            for (int i = 0; i < inAry.Length - 1; i++)
            {
                maxIndex = i;
                for (int j = i + 1; j < inAry.Length; j++)
                {
                    if (inAry[j] > inAry[maxIndex])
                    {
                        maxIndex = j;
                    }
                }
                tempValue = inAry[maxIndex];
                inAry[maxIndex] = inAry[i];
                inAry[i] = tempValue;
            }
            return inAry;
        }
    }
}
