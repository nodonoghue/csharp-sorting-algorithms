namespace sorting_algorithms.BL
{
    internal static class Utilities
    {
        internal static int[] GenerateArray(int aryLength)
        {
            Random rand = new();
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

        internal static void OutputResults(int[] inAry, string sortType, string sortDirection)
        {
            Console.WriteLine("-------------------------------------");
            Console.WriteLine($"{sortType} {sortDirection}");
            foreach (int i in inAry) Console.Write(i.ToString() + ", ");
            Console.WriteLine();
        }
    }
}
