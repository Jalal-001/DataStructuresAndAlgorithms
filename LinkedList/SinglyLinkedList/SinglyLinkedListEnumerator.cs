using System.Collections;

namespace DataStructures.LinkedList.SingleLinkedList
{
    public class SinglyLinkedListEnumerator<T> : IEnumerator<T>
    {
        private SinglyLinkedListNode<T> Head;
        private SinglyLinkedListNode<T> Curr;
        public SinglyLinkedListEnumerator(SinglyLinkedListNode<T> head)
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

            if (Curr is null)
            {
                Curr = Head;
                return true;
            }

            while (Curr.Next != null)
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
