using DataStructures.Array;
using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ArrayTest
{
    public class ArrayListTest
    {
        private ArrayList _arrayList;
        public ArrayListTest()
        {
            // Arrange for all methods
            _arrayList = new ArrayList();
        }

        [Theory]
        [InlineData(2)]
        [InlineData(4)]
        [InlineData(8)]
        [InlineData(16)]
        [InlineData(32)]
        [InlineData(64)]
        public void ArrayList_Constructor(int defaultSize)
        {
            // Arrange | Act
            var arrayList = new ArrayList(defaultSize); //DataStructures.Array.

            // Act
            Assert.Equal(defaultSize, arrayList.Count);
        }

        [Fact]
        public void ArrayList_Add_Test()
        {
            // Act
            for (int i = 0; i < 50; i++)
            {
                _arrayList.Add(i);
            }

            // Assert
            Assert.Equal(64, _arrayList.Length);
            // because defaultSize=2 (2,4,8,16,32,64)
        }

        [Theory]
        [InlineData(32)]
        [InlineData(64)]
        [InlineData(128)]
        [InlineData(256)]
        public void ArrayList_Remove_Test(int innerlength)
        {
            // Arrange
            for (int i = 0; i < innerlength; i++)
            {
                _arrayList.Add(i);
            }

            // Assert
            Assert.Equal(innerlength, _arrayList.Length);

            // Act
            for (int i = _arrayList.Length-1; i > 4; i--)
            {
                _arrayList.Remove();
            }

            // Assert
            Assert.Equal(16, _arrayList.Length);       
        }

        [Fact]
        public void Foreach_Test()
        {
            // Arrange
            _arrayList.Add("a");
            _arrayList.Add("b");
            _arrayList.Add("c");
            _arrayList.Add("d");

            _arrayList.Remove();
            _arrayList.Remove();

            // Act
            string s = "";
            foreach (var item in _arrayList)
            {
                s += item;
            }
         
            // Assert
            Assert.Equal("ab", s);
        }

        [Fact]
        public void Arraylist_Constructor_With_IEnumerable()
        {
            // Arrange
            var arrayList = new List<int> {1,2,3};

            // Act
            var _arr = new ArrayList(arrayList);
            string s = "";
            foreach (var item in _arr)
            {
                s += item;
            }

            // Assert
            Assert.Equal("123", s);
        }

        [Fact]
        public void IndexOf_Test()
        {
            // Arrange
            _arrayList.Add("a");
            _arrayList.Add("b");
            _arrayList.Add("c");

            // Act
            var result=_arrayList.IndexOf("c");

            // Assert
            Assert.Equal(2, result);

        }
    }
}
