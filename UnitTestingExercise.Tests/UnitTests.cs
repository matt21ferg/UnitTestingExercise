using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(1, 2, 3, 6)]
        [InlineData(5,6,7, 18 )]
        [InlineData(6,8,9, 23)]
        [InlineData(7,9,10, 26)]
        [InlineData(0,-2 ,2, 0)]
        public void Add(int num1, int num2, int num3, int expected)
        {
            //Arrange
            var addMeth = new UnitTestMethods();

            //Act
            var acuall = addMeth.Add(num1, num2, num3);
            //Assert
            Assert.Equal(expected, acuall);
        }

        [Theory]
        [InlineData(7,3, 4)]
        [InlineData(8,4, 4)]
        [InlineData(50,20, 30)]
        [InlineData(81,20, 61)]
        [InlineData(0 ,20, -20)]
        [InlineData(1 ,20, -19)]
        public void Subtract(int minuend, int subtrhend, int expected)
        {
            //Arrange
            var subMeth = new UnitTestMethods();
            //Act
            var actuall = subMeth.Difference(minuend, subtrhend);
            //Assert
            Assert.Equal(expected, actuall);
        }

        [Theory]
        [InlineData(3,3, 9)]
        [InlineData(9,2, 18)]
        [InlineData(5,5, 25)]
        [InlineData(8,8, 64)]
        [InlineData(6,-7, -42)]
        [InlineData(7,7, 49)]

        public void Multiply(int num1, int num2, int expected)
        {
            //Arrange
            var multMeth = new UnitTestMethods();  

            //Act
            var actuall = multMeth.Multiply(num1, num2);
            //Assert
            Assert.Equal(expected, actuall);
        }

        [Theory]
        [InlineData(4,2, 2)]
        [InlineData(6,2, 3 )]
        [InlineData(55,11, 5)]
        [InlineData(5,5, 1)]
        [InlineData(8,-4, -2)]
        [InlineData(100,-10, -10)]
        [InlineData(99,9, 11)]
        public void Divide(int num1, int num2, int expected)
        {
            //Arrange
            var divideMeth = new UnitTestMethods();
            //Act
            var actuall = divideMeth.Divide(num1, num2);
            //Assert
            Assert.Equal(expected, actuall);

        }

        [Fact]
        public void GetMatt()
        {
            //Arrange
            var matt = new UnitTestMethods();

            //Act
            var actuall = matt.getMatt();

            //Assert
            Assert.Equal("Matt!", actuall);
        }

        [Fact]
        public void GetHello()
        {
            //Arrange
            var hello = new UnitTestMethods();
            //Act
            var actuall = hello.GetHello();
            //Assert
            Assert.Equal("Hello!", actuall);
                
        }
    }
}
