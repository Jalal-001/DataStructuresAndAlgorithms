using System.Collections;

namespace DataStructures.Array.Generic
{
    public class ArrayEnumerator<T> : IEnumerator<T>
    {
        private T[] _array;
        private int index;
        private Array<int> array;
        private int v;
        private int position;

        public ArrayEnumerator(T[] array, int position)
        {
            _array = array;
            this.position = position;   
        }

        public ArrayEnumerator(Array<int> array, int v)
        {
            this.array = array;
            this.v = v;
        }

        public T Current => _array[index];

        object IEnumerator.Current => Current;

        public void Dispose()
        {
            _array = null;
        }

        public bool MoveNext()
        {
           if(index < _array.Length-1)
            {
                index++;
                return true;
            }
            return false;
        }

        public void Reset()
        {
            index = -1;
        }
    }
}
