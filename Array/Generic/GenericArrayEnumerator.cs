using System.Collections;

namespace DataStructures.Array.Generic
{
    public class GenericArrayEnumerator<T> : IEnumerator<T>
    {
        private T[] _array;
        private int index = -1;
    
        public GenericArrayEnumerator(T[] array)
        {
            _array = array;
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
