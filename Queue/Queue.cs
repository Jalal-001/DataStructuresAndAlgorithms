using DataStructures.Queue.Contract;
using Queue;
using System.Collections;

namespace DataStructures.Queue
{
    public class Queue<T> : IQueue<T>
    {
        private readonly IQueue<T> _queue;
        public Queue(QueueType type=QueueType.DoublyLinkedListQueue)
        {
            switch (type)
            {
                case QueueType.ArrayQueue:
                    _queue = new ArrayQueue<T>();
                    break;
                case QueueType.DoublyLinkedListQueue:
                    _queue = new LinkedListQueue<T>();
                    break;
                default:
                    throw new Exception("Undefined type");
                    break;
            }
        }
        public int Count => _queue.Count;

        public T DeQueue()
        {
            return _queue.DeQueue();
        }

        public void EnQueue(T item)
        {
            _queue.EnQueue(item);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return _queue.GetEnumerator();
        }

        public T Peek()
        {
            return _queue.Peek();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}