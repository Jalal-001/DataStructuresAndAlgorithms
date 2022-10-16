using Stack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackTest
{
    public class LinkedListStackTest
    {
        private readonly LinkedListStack<char> _list;
        public LinkedListStackTest()
        {
            _list = new LinkedListStack<char>(new char[] {'W','e','l','c','o','m','e'});
        }
        [Fact]
        public void Count_Test()
        {
            Assert.Equal(7, _list.Count);
        }
        [Fact]
        public void Peek_Test()
        {
            var result = _list.Peek();
            Assert.Equal('e', result);
        }
        [Fact]
        public void Pop_Test()
        {
            var result = _list.Pop();
            Assert.Equal('e', result);
            Assert.Collection(_list,
                item => Assert.Equal(item, 'm'),
                item => Assert.Equal(item, 'o'),
                item => Assert.Equal(item, 'c'),
                item => Assert.Equal(item, 'l'),
                item => Assert.Equal(item, 'e'),
                item => Assert.Equal(item, 'W'));
        }
    }
}
