using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Array
{
    public class ArrayList : Array,IEnumerable
    {
        private int position; 
        public int Count => InnerArray.Length;
        // Testde hem 'count' hemde 'length' ist. et. olar.

        public ArrayList(int defaultSize = 2) : base(defaultSize)
        {
            position = 0;
        }

        public ArrayList(IEnumerable collection):this()
        {
            foreach (var item in collection)
            {
                // Gelen collection uzvlerinin shexsi Arraylist sinifimizde saxlanilmasi.
                Add(item);
            }
        }

        public void Add(Object value)
        {
            if (position == InnerArray.Length)
                DoubleAdd();
            if (position < InnerArray.Length)
            { 
                InnerArray[position] = value;
                //SetValue(value, position); second way
                position++;
                return;
            }
            throw new Exception();

        }
        private void DoubleAdd()
        {
            try
            {
                var temp = new Object[InnerArray.Length * 2];
                System.Array.Copy(InnerArray, temp, InnerArray.Length);
                InnerArray = temp; // take that referance
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Object Remove()
        {
            if (position >= 0)
            {
                var temp = InnerArray[position - 1];
                position--;
                if (position == InnerArray.Length / 4)
                {
                    HalfArray();
                }
                return temp;
            }
            throw new Exception();
        }
        private void HalfArray()
        {
            try
            {
                var temp = new Object[InnerArray.Length / 2];
                System.Array.Copy(InnerArray, temp, temp.Length / 2);
                InnerArray = temp;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

       new public IEnumerator GetEnumerator()
        {
            return InnerArray.Take(position).GetEnumerator();
        }
    }
}
