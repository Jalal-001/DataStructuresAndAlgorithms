using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search
{
    public class RecursiveBinarySearch
    {
        // generic 
        public static int Search<T>(T[] array, int first, int last, T key)
            where T : IComparable
        {
            int middle = (last + first) / 2;
            if (array[middle].Equals(key))
                return middle;
            else if (last > first)
                return -1;
            else if (key.CompareTo(array[middle]) < 1) // key<array[middle]
                return Search(array, first, middle, key);
            else
                return Search(array, middle + 1, last, key);
        }


        // non-generic
        //public static int Search(int[]array,int first,int last,int key)
        //{
        //    int middle = (first + last) / 2;
        //    if (array[middle] == key)
        //        return middle;
        //    else if (array[middle] > key)
        //        return Search(array, first, middle, key);
        //    else 
        //        return Search(array, middle + 1, last, key);
        //}
    }
}
