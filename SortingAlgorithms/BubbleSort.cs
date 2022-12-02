namespace SortingAlgorithms
{
    public class BubbleSort
    {
        public static void Sort<T>(T[] array)
            where T : IComparable<T>
        {
            int n = array.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int o = 0; o < n - i - 1; o++) // n-i-1 => remove past number and continue
                {
                    if (array[o].CompareTo(array[o + 1]) >= 1) // [o]>[o+1]
                        Sorting.Swap(array, o, o + 1);
                }
            }
        }
    }
}