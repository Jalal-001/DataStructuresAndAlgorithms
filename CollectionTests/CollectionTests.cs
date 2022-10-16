using Xunit;

namespace CollectionTests
{
    public class CollectionTests
    {
        List<int> leftList;
        List<int> rightList;
        public CollectionTests()
        {
            leftList = new List<int> { 1, 2, 3, 4, 4, 5 };
            rightList = new List<int> { 4, 5, 6, 7, 8 };
        }


        [Fact]
        public void Add()
        {
            leftList.Add(10);
            Assert.Equal(7, leftList.Count);
        }
        [Fact]
        public void AddRange_Test()
        {
            leftList.AddRange(new List<int> { 9, 10 });
            Assert.Collection(leftList,
                item => Assert.Equal(item, leftList[0]),
                item => Assert.Equal(item, leftList[1]),
                item => Assert.Equal(item, leftList[2]),
                item => Assert.Equal(item, leftList[3]),
                item => Assert.Equal(item, leftList[4]),
                item => Assert.Equal(item, leftList[5]),
                item => Assert.Equal(item, leftList[6]),
                item => Assert.Equal(item, leftList[7]));
        }
        [Fact]
        public void InterSection_Test()
        {
            // Her ikisinde ortaq olanlar
            var interSectionSet = leftList.Intersect(rightList);
            Assert.Collection(interSectionSet,
                item => Assert.Equal(4, item),
                item => Assert.Equal(5, item));
        }
        [Fact]
        public void Union_Test()
        {
            // Ortaq olanlar(tekrarlananlar) silinir.
            var UnionSet=leftList.Union(rightList);
            Assert.Collection(UnionSet,
                item => Assert.Equal(item, 1),
                item => Assert.Equal(item, 2),
                item => Assert.Equal(item, 3),
                item => Assert.Equal(item, 4),
                item => Assert.Equal(item, 5),
                item => Assert.Equal(item, 6),
                item => Assert.Equal(item, 7),
                item => Assert.Equal(item, 8)
                );
        }
    }
}