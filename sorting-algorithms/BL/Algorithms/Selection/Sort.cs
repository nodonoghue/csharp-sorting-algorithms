using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace sorting_algorithms.BL.Algorithms.Selection
{
    /// <summary>
    /// Seletion sort iterates throught he array to find the smallest or largest and place that value in the left-most place in the array, then iterate through again
    /// until all values have been selected and placed into the correct place in the array
    /// </summary>
    internal class Sort
    {
        /// <summary>
        /// Selection sort in ascending order
        /// </summary>
        /// <param name="inAry"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public void Ascending(int[] saAry)
        {
            int minIndex;
            int tempValue;

            for (int i = 0; i < saAry.Length - 1; i++)
            {
                minIndex = i;
                for (int j = i + 1; j < saAry.Length; j++)
                {
                    if (saAry[j] < saAry[minIndex])
                    {
                        minIndex = j;
                    }
                }
                tempValue = saAry[minIndex];
                saAry[minIndex] = saAry[i];
                saAry[i] = tempValue;
            }
            foreach (int i in saAry) Console.Write(i.ToString() + ", ");
            Console.WriteLine();
        }

        /// <summary>
        /// Selection sort in descending order
        /// </summary>
        /// <param name="inAry"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public void Descending(int[] sdAry)
        {
            int maxIndex;
            int tempValue;

            for (int i = 0; i < sdAry.Length - 1; i++)
            {
                maxIndex = i;
                for (int j = i + 1; j < sdAry.Length; j++)
                {
                    if (sdAry[j] > sdAry[maxIndex])
                    {
                        maxIndex = j;
                    }
                }
                tempValue = sdAry[maxIndex];
                sdAry[maxIndex] = sdAry[i];
                sdAry[i] = tempValue;
            }

            foreach (int i in sdAry) Console.Write(i.ToString() + ", ");
            Console.WriteLine();
        }
    }
}
