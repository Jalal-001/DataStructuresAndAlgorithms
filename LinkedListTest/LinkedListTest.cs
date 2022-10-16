using DataStructures.LinkedList.SingleLinkedList;

namespace LinkedListTest
{
    public class LinkedListTest
    {
        private SinglyLinkedList<int> _list;
        public LinkedListTest()
        {
            _list = new SinglyLinkedList<int>(new int[] {5,8});
        }
        [Fact]
        public void Count_Test()
        {
            var count = _list.Count;
            Assert.Equal(2, count);
        }
        [Theory]
        [InlineData(3)]
        [InlineData(9)]
        [InlineData(12)]
        public void AddFirst_Test(int value)
        {
            var newList=new SinglyLinkedList<int>();
            newList.AddFirst(value);
            Assert.Equal(value,newList.Head.Value);

            Assert.Collection(newList,
                item => Assert.Equal(item, value)
            );
        }
        [Fact]
        public void GetEnumerator_Test()
        {
            Assert.Collection(_list,
                item => Assert.Equal(item, 8),
                item => Assert.Equal(item, 5));
        }
        [Theory]
        [InlineData(60)]
        public void AddLast_Test(int value)
        {
            _list.AddLast(value);
            Assert.Collection(_list,
                item => Assert.Equal(item, 8),
                item => Assert.Equal(item, 5),
                item => Assert.Equal(item, value));
        }
        [Theory]
        [InlineData(12)]
        [InlineData(22)]
        [InlineData(37)]
        [InlineData(68)]
        public void AddBefore_Test(int value)
        {
            _list.AddBefore(_list.Head.Next, value);
            Assert.Collection(_list,
                item => Assert.Equal(8, item),
                item => Assert.Equal(value, item),
                item => Assert.Equal(5, item)
            );
        }
        
        [Fact]
        public void AddBefore_ArgumentException_Test()
        {
            var node = new SinglyLinkedListNode<int>(42);
            Assert.Throws<ArgumentException>(() => _list.AddBefore(node, 68));
        }
        [Theory]
        [InlineData(12)]
        [InlineData(22)]
        [InlineData(37)]
        [InlineData(68)]
        public void AddAfter_Test(int value)
        {
            _list.AddAfter(_list.Head, value);
            Assert.Collection(_list,
                item => Assert.Equal(8,item),
                item => Assert.Equal(value,item),
                item => Assert.Equal(5,item)
                );

        }
        [Fact]
        public void AddAfter_ArgumentException_Test()
        {
            var node = new SinglyLinkedListNode<int>(88);
            Assert.Throws<ArgumentException>(() => _list.AddBefore(node, 68));
        }
        [Fact]
        public void RemoveFirst_Test()
        {
            var result=_list.RemoveFirst();
            Assert.Collection(_list, item => Assert.Equal(5, item));
            Assert.Equal(result, 8);
        }
        [Fact]
        public void RemoveFirst_Exception_Test()
        {
            _list.RemoveFirst();
            _list.RemoveFirst();
            Assert.Throws<Exception>(() => _list.RemoveFirst());
        }
        [Fact]
        public void RemoveLast_Test()
        {
          var result=_list.RemoveLast();
            Assert.Collection(_list, item => Assert.Equal(8, item));
            Assert.Equal(5, result);
        }
        [Theory]
        [InlineData(8)]
        public void Remove_Test(int value)
        {
            _list.AddFirst(10);
            _list.Remove(value);
            Assert.Collection(_list,
                item=>Assert.Equal(10,item),
                item=>Assert.Equal(5,item));
        }
    }
}