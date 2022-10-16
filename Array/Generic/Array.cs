using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Array.Generic
{
    public class Array<T>:ICloneable,IEnumerable<T>
    {
        protected T[] InnerArray { get; set; }
        public int Length => InnerArray.Length;

        private int position;
        public int Count => position;

        public Array(int defaultSize = 2)
        {
            position = 0;
            InnerArray = new T[defaultSize];
        }
        public Array(params T[] sourceArray) : this(sourceArray.Length)
        {
            //InnerArray = new Object[sourceArray.Length] = :this(sourceArray.Length) / OOP Constructor work
            System.Array.Copy(sourceArray, InnerArray, sourceArray.Length);
        }
        public Array(IEnumerable<T> collection):this()
        {
            foreach (var item in collection)
            {
                // Gelen collection uzvlerinin shexsi Array sinifimizde saxlanilmasi.
                Add(item);
            }
        }

        public Array(T[] ınnerArray, int position)
        {
            InnerArray = ınnerArray;
            this.position = position;
        }

        public T GetValue(int index)
        {
            if (!(index >= 0 && index < InnerArray.Length))
                throw new ArgumentOutOfRangeException();
            return InnerArray[index];
        }
        public void SetValue(T value, int index)
        {
            if (!(index >= 0 && index < InnerArray.Length))
                throw new ArgumentOutOfRangeException();
            if (value == null)
                throw new ArgumentNullException();
            InnerArray[index] = value;
        }
        public object Clone()
        {
            return MemberwiseClone();
        }
        
        public int IndexOf(T value)
        {
            for (int i = 0; i < InnerArray.Length; i++)
            {
                if (GetValue(i).Equals(value))
                    return i;
            }
            return -1;
        }
        
        // --- //
        public void Add(T value)
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
                var temp = new T[InnerArray.Length * 2];
                System.Array.Copy(InnerArray, temp, InnerArray.Length);
                InnerArray = temp; // take that referance
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public T Remove()
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
                var temp = new T[InnerArray.Length / 2];
                System.Array.Copy(InnerArray, temp, temp.Length / 2);
                InnerArray = temp;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new ArrayEnumerator<T>(InnerArray, position);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
