using LinkedList.DoblyLinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListTest
{
    public class DoublyLinkedListTest
    {
        // Context
        DoublyLinkedList<char> _list;
        public DoublyLinkedListTest()
        {
            _list = new DoublyLinkedList<char>(new char[] { 'a', 'z' });
        }
        [Theory]
        [InlineData('d')]
        [InlineData('e')]
        [InlineData('b')]
        public void AddFirst_Test(char value)
        {
            // act
            _list.AddFirst(value);
            //Assert
            Assert.Equal(value, _list.Head.Value);
        }
        [Theory]
        [InlineData('j')]
        [InlineData('o')]
        [InlineData('k')]
        public void AddLast_Test(char value)
        {
            // a z + j o k
            _list.AddLast(value);
            var tailValue = _list.Tail.Value;

            Assert.Equal(value, tailValue);
            Assert.Collection(_list,
                item => Assert.Equal(item,_list.Head.Value),
                item => Assert.Equal(item, _list.Head.Next.Value),
                item => Assert.Equal(value, _list.Tail.Value));
        }
        [Fact]
        public void Count_Test()
        {
            var result = _list.Count;
            Assert.Equal(2, result);
        }
        [Theory]
        [InlineData('b')]
        [InlineData('x')]
        [InlineData('r')]
        public void AddBeforeTest(char value)
        {
            // z a
            _list.AddBefore(_list.Head.Next, value);
            Assert.Collection(_list,
                item => Assert.Equal(item,_list.Head.Value),
                item => Assert.Equal(item, value),
                item => Assert.Equal(item, 'a') //***
                );
        }
        [Theory]
        [InlineData('b')]
        [InlineData('x')]
        [InlineData('r')]
        public void AddAfter_Test(char value)
        {
            _list.AddAfter(_list.Head, value);
            Assert.Collection(_list,
                item => Assert.Equal(item, _list.Head.Value),
                item => Assert.Equal(value, _list.Head.Next.Value),
                item => Assert.Equal(item,'a')
                );
        }
        [Fact]
        public void RemoveFirst_Test()
        {
            _list.RemoveFirst();
            Assert.Collection(_list,item => Assert.Equal(item, 'a'));  
        }
        [Fact]
        public void RemoveLast_Test()
        {
           var r1= _list.RemoveLast(); //a
           var r2= _list.RemoveLast(); //z
            Assert.Equal(r1,'a'); 
            Assert.Equal(r2,'z');
        }
        [Theory]
        [InlineData('J')]
        public void Remove_Test(char value)
        {
            _list.AddLast(value);
            var r1 = _list.Remove(value);
            Assert.Equal(r1, 'J');
            Assert.Collection(_list,
                item => Assert.Equal(item, 'z'),
                item => Assert.Equal(item, 'a'));   
        }
        [Fact]
        public void Tolist_Test()
        {
            var list = _list.Tolist;
            Assert.Collection(list,
                item => Assert.Equal(item, _list.Head.Value),
                item => Assert.Equal(item, _list.Head.Next.Value));
        }
    }
}
