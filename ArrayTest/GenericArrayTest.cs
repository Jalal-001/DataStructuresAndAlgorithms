
using System;
using Xunit;
using System.Collections.Generic;
using DataStructures.Array.Generic;


namespace ArrayTest
{
    public class GenericArrayTest
    {
        private Array<char> _array;
        public GenericArrayTest()
        {
            // Arrange
            _array = new Array<char>(new char[] { 's', 'a', 'm', 'u' });
        }

        [Theory]
        [InlineData(8)]
        [InlineData(16)]
        [InlineData(32)]
        [InlineData(64)]
        public void Constructor_Test( int size)
        {
            // Arrange - Act
           var arr=new Array<char>[size];

            // Arrange
            Assert.Equal(size, arr.Length);  
        }
        [Fact]
        public void Params_Test()
        {
            // Arrange - Act
            var arr = new Array<int> { 1, 2, 3, 4 };

            // Assert
            Assert.Equal(4,arr.Length);
        }
        [Fact]
        public void GetValue_Test()
        {
            // Arrange
            var c = _array.GetValue(0);

            // Assert
            Assert.Equal('s', c);
        }
        [Fact]
        public void SetValue_Test()
        {
            // Arrange - Act
            var arr = new Array<string>();
            arr.SetValue("Plumber", 0);

            // Assert
            Assert.Equal("Plumber", arr.GetValue(0));

        }

        [Fact]
        public void Clone_Test()
        {
            // Arrange - Act
            var genericClone = _array.Clone() as DataStructures.Array.Generic.Array<char>;

            // Assert
            Assert.Equal(genericClone.Length,_array.Length);
            Assert.NotNull(genericClone);
            Assert.NotEqual(genericClone.GetHashCode(), _array.GetHashCode());
        }

        [Fact]
        public void Generic_GetEnumerator_Test()
        {
            // Fail //
            
            
        }
        [Fact]
        public void IndexOf_Test()
        {
            // Arrange
            _array.Add('b');
            _array.Add('a');
            _array.Add('d');

            // Act
            var i = _array.IndexOf('a');

            // Assert
            Assert.Equal(i, 1);    
        }

        [Fact]
        public void Generic_Add_Test()
        {
            // Arrange
            var arr= new Array<int>();

            // Act
            for (int i = 0; i < 34; i++)
            {
                arr.Add(i);
            }

            // Assert
            Assert.Equal(arr.Length, 64);

        }
        [Theory]
        [InlineData(32)]
        [InlineData(64)]
        [InlineData(128)]
        [InlineData(256)]
        public void Generic_Remove_Test(int size)
        {
            var arr = new Array<int>(size);   
            for (int i = 0; i <size; i++)
            {
                arr.Add(i);
            }
            Assert.Equal(arr.Length, size);

            for (int i = arr.Length-1; i > 8; i--)
            {
                arr.Remove();
            }
            Assert.Equal(32, arr.Length);
        }
    }
}
