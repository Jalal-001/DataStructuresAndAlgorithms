using Stack;

namespace StackTest
{
    public class ArrayStackTest
    {
        private ArrayStack<char> _stack;
        public ArrayStackTest()
        {
            _stack = new ArrayStack<char>(new char[] {'H','e','l','l','o'});
        }
        [Fact]
        public void Count_Test()
        {
            Assert.Equal(5, _stack.Count);
        }
        [Fact]
        public void Pop_Test()
        {
            var pop = _stack.Pop();
            Assert.Equal('o', pop);
            Assert.Equal(_stack.Count, 4);

            //ArrayEnumerator - da position nezere alinmadigi uchun xeta.
            //Assert.Collection(_stack,
            //    item => Assert.Equal(item, 'l'),
            //    item => Assert.Equal(item, 'l'),
            //    item => Assert.Equal(item, 'e'),
            //    item => Assert.Equal(item, 'H'));
        }
        [Theory]
        [InlineData('W')]
        //[InlineData('o')]
        //[InlineData('w')]
        public void Peek_Test(char value)
        {
            _stack.Push(value);
            Assert.Equal('W', _stack.Peek());
        }
    }
}