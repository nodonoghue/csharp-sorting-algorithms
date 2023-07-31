using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sorting_algorithms.BL.Algorithms.Interfaces
{
    internal interface ISort
    {
        public int[] Ascending(int[] inAry);
        public int[] Descending(int[] inAry);
    }
}
