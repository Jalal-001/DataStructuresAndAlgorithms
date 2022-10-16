using DataStructures.Array.Generic;
using Stack.Contract;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class ArrayStack<T> : IStack<T>
    {
        private readonly Array<T> _array;
        public int Count => _array.Count;

        public ArrayStack()
        {
            _array = new Array<T>();
        }
        public ArrayStack(IEnumerable<T> collection):this()
        {
            foreach (var item in collection)
            {
                Push(item);
            }
        }
        
        public IEnumerator<T> GetEnumerator()
        {
           return _array.GetEnumerator();
        }

        public T Peek()
        {
            if (Count == 0)
                return default(T);
            return _array.GetValue(_array.Count - 1);
        }

        public T Pop()
        {
            if (_array.Count == 0)
                throw new Exception("Empty stack!");
            var result = _array.Remove();
            return result;
        }

        public void Push(T item)
        {
            _array.Add(item);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
