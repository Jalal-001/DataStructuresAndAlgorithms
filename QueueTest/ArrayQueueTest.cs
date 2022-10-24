using Queue;

namespace QueueTest
{
    public class ArrayQueueTest
    {
        private readonly ArrayQueue<int> _arrayList;
        public ArrayQueueTest()
        {
            _arrayList = new ArrayQueue<int>(new int[] { 10,20,30} );
        }
       
        [Fact]
        public void Count_Test()
        {
            var result= _arrayList.Count(); 
            Assert.Equal(result, 3);
        }
        [Fact]
        public void DeQueu_Test()
        {
            var temp = _arrayList.DeQueue();
            Assert.Equal(temp, 10);

            Assert.Collection(_arrayList,
                item => Assert.Equal(item, 20),
                item => Assert.Equal(item, 30));
        }
        [Theory]
        [InlineData(57)]
        public void EnQueue_Test(int value)
        {
            _arrayList.EnQueue(value);
            Assert.Equal(_arrayList.Count,4);
            Assert.Collection(_arrayList,
                item => Assert.Equal(item, 10),
                item => Assert.Equal(item, 20),
                item => Assert.Equal(item, 30),
                item => Assert.Equal(item, 57)
                );
        }
        [Fact]
        public void Peek_Test()
        {
            var temp = _arrayList.Peek();
            Assert.Equal(temp, 10);
        }
    }
}