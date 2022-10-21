using DataStructures.Queue.Contract;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    public class ArrayQueue<T> : IQueue<T>
    {
        private readonly List<T> _list;
        public ArrayQueue()
        {
            _list = new List<T>();
        }
        public ArrayQueue(IEnumerable<T> collection):this()
        {
            foreach (var item in collection)
            {
                EnQueue(item);
            }
        }
        public int Count => _list.Count;

        public T DeQueue()
        {
            if (Count == 0)
                throw new EmptyQueueException();

            var temp = _list[0];
            _list.RemoveAt(0);
            return temp;
        }

        public void EnQueue(T item)
        {
            _list.Add(item);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return _list.GetEnumerator();
        }

        public T Peek()
        {
            return _list[0];
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
