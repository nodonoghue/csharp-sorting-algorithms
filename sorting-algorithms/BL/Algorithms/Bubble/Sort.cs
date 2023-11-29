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
        public static void Ascending(int[] baAry)
        {
            bool swapped;
            int swapValue;
            for (int i = 0; i < baAry.Length - 1; i++)
            {
                swapped = false;
                for (int j = 0; j < baAry.Length - 1 - i; j++)
                {
                    if (baAry[j] > baAry[j + 1])
                    {
                        swapped = true;
                        swapValue = baAry[j];
                        baAry[j] = baAry[j + 1];
                        baAry[j + 1] = swapValue;
                    }
                }
                if (swapped == false) break;
            }
        }

        /// <summary>
        /// Bubble sort in descending order
        /// </summary>
        /// <param name="inAry"></param>
        /// <returns></returns>
        public static void Descending(int[] bdAry)
        {
            bool swapped;
            int swapValue;
            for (int i = 0; i < bdAry.Length - 1; i++)
            {
                swapped = false;
                for (int j = 0; j < bdAry.Length - 1 - i; j++)
                {
                    if (bdAry[j] < bdAry[j + 1])
                    {
                        swapped = true;
                        swapValue = bdAry[j];
                        bdAry[j] = bdAry[j + 1];
                        bdAry[j + 1] = swapValue;
                    }
                }
                if (swapped == false) break;
            }
        }
    }
}
