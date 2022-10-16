using System.Collections;

namespace DataStructures.LinkedList.SingleLinkedList
{
    public class SinglyLinkedList<T> : IEnumerable<T>
    {
        public SinglyLinkedListNode<T> Head { get; set; }
        public int Count { get; set; }
        public bool isHeadNull => Head == null;
        public SinglyLinkedList()
        {
            Head = null;
            Count = 0;
        }
        public SinglyLinkedList(IEnumerable<T> collection) : this()
        {
            foreach (var item in collection)
            {
                AddFirst(item);
            }
        }

        public void AddFirst(T value)
        {
            var newNode = new SinglyLinkedListNode<T>(value);

            if (isHeadNull)
            {
                Head = newNode;
                Count++;
                return;
            }
            newNode.Next = Head;
            Head = newNode;
            Count++;
            return;
        }
       
        public void AddLast(T value)
        {
            var newNode = new SinglyLinkedListNode<T>(value);
            if (isHeadNull)
            {
                Head = newNode;
                Count++;
                return;
            }
            var current = Head;
            var prev = current;
            while (current.Next != null)
            {
                prev = current;
                current = current.Next;
            }
            current.Next = newNode;
            Count++;
            return;
        }
        
        public void AddBefore(SinglyLinkedListNode<T> node, T value)
        {
            if (node is null)
                throw new ArgumentNullException(nameof(node));
            if (isHeadNull || node.Equals(Head))
            {
                AddFirst(value);
                return;
            }
            var newNode = new SinglyLinkedListNode<T>(value);
            var current = Head;
            var prev = current;
            while (current.Next != null)
            {
                prev = current;
                current = current.Next;
                if (current.Equals(node))
                {
                    newNode.Next = prev.Next;
                    prev.Next = newNode;
                    Count++;
                    return;
                }
            }
            throw new ArgumentException("There is no such a node in the linked list!");
        }
       
        public void AddAfter(SinglyLinkedListNode<T> node, T value)
        {
            if (node == null)
                throw new ArgumentNullException(nameof(node));
            if (isHeadNull)
            {
                AddFirst(value);
                Count++;
                return;
            }
            var newNode = new SinglyLinkedListNode<T>(value);
            var current = Head;
            var prev = current;
            while (current.Next != null)
            {
                newNode.Next = current.Next;
                current.Next = newNode;
                Count++;
                return;
            }
            current = current.Next;
            throw new ArgumentException("There is no such a node in the List");
        }
       
        public T RemoveFirst()
        {
            if (isHeadNull)
                throw new Exception(nameof(Head));
            var temp = Head;
            Head = Head.Next;
            Count--;
            return temp.Value;
        }
       
        public T RemoveLast()
        {
            if (isHeadNull || Count==0)
                throw new Exception(nameof(Head));
            if (Count == 1)
                RemoveFirst();

            var current = Head;
            var prev= current;
            while(current.Next != null)
            {
                prev = current;
                current = current.Next;
            }
            prev.Next = null;
            Count--;
            return current.Value;
        }
        
        public T Remove(T value)
        {
            if(isHeadNull || Count==0)
                throw new Exception(nameof(Head));
            if(Head.Value.Equals(value)) //Array-in ilk deyerini silmek isteyirikse
                return RemoveFirst();
            
            var current=Head;
            var prev= current;
            while(current.Next!= null)
            {
                current=current.Next;
                if (current.Value.Equals(value))
                {
                    prev.Next = current.Next;
                    Count--;
                    return current.Value;
                }
            }
            throw new ArgumentException("There is no such element in the list");
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new SinglyLinkedListEnumerator<T>(Head);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
       
        public List<T> Tolist => new List<T>(this);
    }
}
