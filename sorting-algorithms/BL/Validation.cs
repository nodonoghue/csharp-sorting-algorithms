using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sorting_algorithms.BL
{
    internal class Validation
    {
        internal static bool isNumeric(string? inputValue)
        {
            if (string.IsNullOrWhiteSpace(inputValue)) return false;
            return int.TryParse(inputValue, out _ );
        }
    }
}
