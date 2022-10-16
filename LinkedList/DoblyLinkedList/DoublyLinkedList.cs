using System.Collections;

namespace LinkedList.DoblyLinkedList
{
    public class DoublyLinkedList<T> : IEnumerable<T>
    {
        public int Count { get; private set; }
        public DbNode<T> Head { get; private set; }
        public DbNode<T> Tail { get; private set; }
        public bool isHeadNull => Head == null;
        public DoublyLinkedList()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }
        public DoublyLinkedList(IEnumerable<T> collection) : this()
        {
            foreach (var item in collection)
            {
                AddFirst(item);// AddLast ***
            }
        }
        public List<T> Tolist => new List<T>(this);
        public void AddFirst(T value)
        {
            var newNode = new DbNode<T>(value);
            if (isHeadNull)
            {
                Head = newNode;
                Count++;
                return;
            }
            newNode.Next = Head;
            Head.Prev = newNode;
            Head = newNode;
            Count++;
            return;
        }
        public void AddLast(T value)
        {
            var newNode = new DbNode<T>(value);
            if (isHeadNull)
            {
                AddFirst(value);
                Count++;
                return;
            }
            // Tail.get returned null **"Exception"**
            var current = Head;
            while (current.Next != null)
            {
                current = current.Next;
                Tail = current;
            }
            Tail.Next = newNode;
            newNode.Prev = Tail;
            Tail = newNode;
            Count++;
            return;
        }
        public IEnumerator<T> GetEnumerator()
        {
            return new DoublyLinkedListEnumerator<T>(Head);
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        public void AddBefore(DbNode<T> node, T value)
        {
            var newNode = new DbNode<T>(value);
            if (node is null || value is null)
                throw new Exception();
            if (isHeadNull || Head.Equals(node))
            {
                AddFirst(value);
                Count++;
                return;
            }
            var current = Head;
            var previus = current;
            while(current.Next != null)
            {
                previus = current;
                current = current.Next;

                if (current.Equals(node))
                {
                    newNode.Next = previus.Next;
                    previus.Next = newNode;
                    newNode.Prev = previus;
                    newNode.Next.Prev = newNode;
                    Count++;
                    return;
                }

            }
            throw new ArgumentException("There is no such a node in the list");
        }
        public void AddAfter(DbNode<T>node,T value)
        {
            var newNode = new DbNode<T>(value);
            if (node is null || value is null)
                throw new ArgumentException();
            if(isHeadNull)
            {
                AddFirst(value);
                Count++;
                return;
            }
            var curr = Head;
            while(curr.Next != null)
            {
                if (curr.Equals(node))
                {
                    newNode.Next = curr.Next;
                    curr.Next = newNode;
                    newNode.Prev = curr;
                    newNode.Next.Prev = newNode;
                    Count++;
                    return;
                }
                else
                {
                    AddLast(value);
                    Count++;
                    return;
                }
                curr = curr.Next;
            }
            throw new ArgumentException("There is no such a node in the list");
        }
        public T RemoveFirst()
        {
            if (isHeadNull)
                throw new Exception(nameof(Head));
            var temp = Head;
            Head = Head.Next;
            Head.Prev = null;
            Count--;
            return temp.Value;
        }
        public T RemoveLast()
        {
            if (isHeadNull || Count == 0)
                throw new Exception(nameof(Head));
            if (Count == 1)
            {
                var temp = Head;
                Head = null;
                Count--;
                return temp.Value;
            }
            else
            {
                // *** // Look
                var curr = Head;
                while (curr.Next != null)
                {
                    curr = curr.Next;
                }
                Tail = curr;
                var temp = Tail;
                Tail.Prev.Next = null;
                Tail = Tail.Prev;
                Count--;
                return temp.Value;
            }

        }
        public T Remove(T value)
        {
            if (isHeadNull)
                throw new Exception(nameof(Head));

            var current = Head;
            var prev = current;
            
            while(current.Next != null)
            {
                prev = current;
                current = current.Next;
                Tail = current;

                if (current.Value.Equals(value))
                {
                    if (current.Value.Equals(Head.Value))
                        return RemoveFirst();
                    if (current.Value.Equals(Tail.Value))
                        return RemoveLast();

                    var temp = current;
                    prev.Next = current.Next;
                    current = null;
                    Count--;
                    return temp.Value;
                }
            }
            throw new Exception("There is no such a value in the list");
        }
    }
}
