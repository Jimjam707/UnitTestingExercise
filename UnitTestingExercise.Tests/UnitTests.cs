using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] 
        [InlineData(1, 2, 3, 6)]
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            var calculator = new Calculator();
            
            //Act
                var actual = calculator.Add(num1, num2, num3);
                

            //Assert
                Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5, 3, 2)]
        [InlineData(10, 5, 5)]
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            var calculator = new Calculator();
            //Act
            var actual = calculator.Subtract(minuend, subtrhend);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2,2,4)]
        [InlineData(3,3,9)]
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            var calculator = new Calculator();
            //Act
            var actual = calculator.Multiply(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(4,2,2)]
        [InlineData(10,5,2)]
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            var calculator = new Calculator();
            //Act
            var actual = calculator.Divide(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

    }
}
