using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace sorting_algorithms.BL
{
    internal static class Utilities
    {
        internal static int[] GenerateArray(int aryLength)
        {
            Random rand = new Random();
            int[] array = new int[aryLength];
            for (int i = 0; i < aryLength; i++)
            {
                array[i] = rand.Next(1, aryLength + 1);
            }
            return array;
        }

        internal static int[] CloneArray(int[] ary)
        {
            return (int[])ary.Clone();
        }
    }
}
