using System.Collections;

namespace LinkedList.DoblyLinkedList
{
    public class DoublyLinkedListEnumerator<T> : IEnumerator<T>
    {
        private DbNode<T> Head { get; set; }
        private DbNode<T> Curr { get; set; }
        public DoublyLinkedListEnumerator(DbNode<T> head)
        {
            this.Head = head;
            Curr = null;
        }
        public T Current => Curr.Value;

        object IEnumerator.Current => Current;

        public void Dispose()
        {
            Head = null;
        }

        public bool MoveNext()
        {
            if (Head is null)
                return false;
            if(Curr is null)
            {
                Curr = Head;
                return true;
            }
            while(Curr.Next != null)
            {
                Curr = Curr.Next;
                return true;
            }
            return false;
        }

        public void Reset()
        {
            Curr = null;
        }
    }
}