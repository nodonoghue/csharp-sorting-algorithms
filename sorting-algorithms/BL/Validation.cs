namespace sorting_algorithms.BL
{
    internal class Validation
    {
        internal static bool IsNumeric(string? inputValue)
        {
            if (string.IsNullOrWhiteSpace(inputValue)) return false;
            return int.TryParse(inputValue, out _ );
        }
    }
}
