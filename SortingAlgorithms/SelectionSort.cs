using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    public class SelectionSort
    {
        public static void Sort<T>(T[] array)
            where T:IComparable<T>
        {
            int n = array.Length;
            for (int i = 0; i < n-1; i++)
            {
                int min = i;
                for (int j = i+1; j < n; j++)
                {
                    if (array[j].CompareTo(array[min])>=1)
                        min = j;
                    Sorting.Swap(array, i, j);
                }   
            }
        }
    }
}
