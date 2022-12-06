namespace Search
{
    public class BinarySearch
    {
        // Iterative
        public static int Search<T>(T[] input, T key)
            where T : IComparable<T>
        {
            return Search(input, 0, input.Length - 1, key);
        }
        private static int Search<T>(T[] input, int i, int j, T key)
            where T : IComparable<T>
        {
            while (true)
            {
                if (i == j)
                {
                    if (input[i].Equals(key))
                    {
                        return i;
                    }
                    return -1;
                }

                int middle = (i + j) / 2;

                if (input[middle].Equals(key))
                {
                    return middle;
                }

                if (input[middle].CompareTo(key) >= 1) // CompareTo => '>' || input[middle]>key
                {
                    j = middle;
                    continue;
                }
                i = middle + 1;
            }
        }
    }
}
