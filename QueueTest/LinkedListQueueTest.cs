using DataStructures.Queue;


namespace QueueTest
{
    public class LinkedListQueueTest
    {
        private LinkedListQueue<int> _linkedList;
        public LinkedListQueueTest()
        {
            _linkedList = new LinkedListQueue<int>(new int[] { 10, 20, 30 });
        }

        [Fact]
        public void Count_Test()
        {
            var result = _linkedList.Count;
            Assert.Equal(result, 3);
        }
        [Fact]
        public void DeQueu_Test()
        {
            var temp = _linkedList.DeQueue();
            Assert.Equal(temp, 10);

            Assert.Collection(_linkedList,
                item => Assert.Equal(item, 20),
                item => Assert.Equal(item, 30));
        }
        [Theory]
        [InlineData(57)]
        public void EnQueue_Test(int value)
        {
            _linkedList.EnQueue(value);
            Assert.Equal(_linkedList.Count, 4);
            
            var peek=_linkedList.Peek();

            Assert.Collection(_linkedList,
                item => Assert.Equal(item, 10),
                item => Assert.Equal(item, 20),
                item => Assert.Equal(item, 30),
                item => Assert.Equal(item, 57));
        }
        [Fact]
        public void Peek_Test()
        {
            _linkedList.DeQueue();
            var temp = _linkedList.Peek();
            Assert.Equal(temp, 20);
        }
    }
}
