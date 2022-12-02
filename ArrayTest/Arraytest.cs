using DataStructures.Array;
using DataStructures.Array.Generic;
using System.Collections;
using Xunit;
using Array = DataStructures.Array.Array;

namespace ArrayTest
{
    public class Arraytest
    {
        [Theory]
        [InlineData(16)]
        [InlineData(32)] 
        [InlineData(64)]    
        [InlineData(128)]   
        [InlineData(256)]   
        public void Check_Array_Constructor(int defaultSize)
        {
            // Arrange |  Act
            var array = new Array(defaultSize);

            //Assert
            Assert.Equal(defaultSize, array.Length);
        }

        [Fact]
        public void Check_Array_Construcctor_WithParams()
        {
            // Arrange & Act
            var array = new Array(1, 2, 3, 4);

            //Assert
            Assert.Equal(4, array.Length);

        }

        [Fact]
        public void Get_And_Set_Value_InArray()
        {
            // Arrange | Act
            var array = new Array();
            array.SetValue(10, 0);
            array.SetValue(20, 1);
            //array.SetValue(30, 17);

            // Assert
            Assert.Equal(10, array.GetValue(0));
            Assert.Equal(20, array.GetValue(1));
            //Assert.Equal(30, array.GetValue(17)); Exception
            Assert.Null(array.GetValue(2));
        }

        [Fact]
        public void Array_Clone_Test()
        {
            // Arrange
            var array = new Array(1, 2, 3);

            // Act
            var arrayClone = array.Clone() as Array;

            // Assert
            Assert.NotNull(arrayClone); // new referance
            Assert.Equal(array.Length, arrayClone.Length);
            Assert.NotEqual(array.GetHashCode(), arrayClone.GetHashCode()); //like value type 
        }
        
        [Fact]
        public void Array_GetEnumerator_Test()
        {
            // Arrange
            var array = new Array(10, 20, 30);

            // Act
            string s = "";
            foreach (var item in array)
            {
                s += item;
            }

            // Assert
            Assert.Equal("102030", s);
        }

        [Fact]
        public void Array_Custom_GetEnumerator_Test()
        {
            // Arrange
            var array =new Array(10, 20, 30);

            // Act
            string s = "";
            foreach (var item in array)
            {
                s += item;
            }

            // Assert
            Assert.Equal("102030", s);
        }

        [Fact]
        public void Remove_Test()
        {
            var arr = new Array<int>();
            arr.Add(1);
            arr.Add(2);
            arr.Add(3);
            var result= arr.Remove();
            Assert.Equal(result,3);
        }
    }
}
