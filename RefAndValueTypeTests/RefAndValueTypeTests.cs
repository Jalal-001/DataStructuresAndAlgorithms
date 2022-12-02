using ReferenceTypeAndValueType;
using ValueType = ReferenceTypeAndValueType.ValueType;

namespace RefAndValueTypeTests
{
    public class RefAndValueTypeTests
    {
        [Fact]
        public void ReferenceTypeTest()
        {
            //Arrange
            var p = new ReferenceType() { X = 10, Y = 20 };
            var p2 = p;

            //Act
            p.X = 60;

            //Assert
            Assert.Equal(p.X, p2.X);
        }

        [Fact]
        public void ValueTypeTest()
        {
            //Arrange
            var p = new ValueType() { X = 10, Y = 20 };
            var p2 = p;

            //Act
            p.X = 60;

            //Assert
            Assert.NotEqual(p.X, p2.X);
        }

        [Fact]
        public void RecordTypeTest()
        {
            // deyerlere gore qarsilasdirma.

            //Arrange
            var p1 = new RecordType(5, 12);

            //Act
            var p2 = new RecordType(6, 80);

            //Assert
            Assert.NotEqual(p1, p2);
        }

        [Fact]
        public void SwapByValue()
        {
            //Arrange
            int x = 25, y = 60;
            var ValType = new ValueType();

            //Act
            ValType.Swap(x, y);

            //Assert
            Assert.Equal(25, x);
            Assert.Equal(60, y);

        }
        [Fact]
        public void SwapByRef()
        {
            //Arrange
            int x = 25, y = 60;
            var ValType = new ReferenceType();

            //Act
            ValType.Swap(ref x,ref y);

            //Assert
            Assert.Equal(60, x);
            Assert.Equal(25, y);

        }
        [Fact]
        public void CheckOut()
        {
            //Arrane
            var refType = new ReferenceType();
            int b = 50;

            //Act
            refType.CheckOutKeyword(out b);

            //Assert
            Assert.Equal(100, b);
        }
    }
}