using Stack.Contract;
using System.Collections;

namespace Stack
{
    public class Stack<T> : IStack<T>
    {
        private readonly IStack<T> _stack;

        public enum StackType
        {
            ArraySatck=0,
            LinkedListStack=1
        }
        public Stack(StackType type= StackType.LinkedListStack)
        {
            switch (type)
            {
                case StackType.ArraySatck:
                    _stack=new ArrayStack<T>();
                    break;
                case StackType.LinkedListStack:
                    _stack=new LinkedListStack<T>();
                    break;

                default:throw new Exception("Undefined type!");
            }
        }

        public int Count => _stack.Count;

        public IEnumerator<T> GetEnumerator()
        {
            return _stack.GetEnumerator();
        }

        public T Peek()
        {
            return _stack.Peek();
        }

        public T Pop()
        {
            return _stack.Pop();
        }

        public void Push(T item)
        {
            _stack.Push(item);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}