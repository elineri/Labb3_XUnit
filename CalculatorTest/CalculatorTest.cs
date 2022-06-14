using System;
using Xunit;
using Labb3_XUnit;
using System.Collections.Generic;

namespace CalculatorTest
{
    public class CalculatorTest
    {
        [Fact]
        [Trait("Category", "Addition")]
        public void Add_2_AND_5_Return_7()
        {
            // Assert
            int num1 = 2;
            int num2 = 5;
            var expected = 7;

            // Act
            var actual = Calculator.Addition(num1, num2);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [Trait("Category", "Addition")]
        [InlineData(50, 50, 100)]
        [InlineData(13, 7, 20)]
        [InlineData(5, -1, 4)]
        [InlineData(-5, 5, 0)]
        [InlineData(1, 0, 1)]
        public void Add_Numbers(double num1, double num2, double expectedResult)
        {
            // Act
            var actual = Calculator.Addition(num1, num2);

            // Assert
            Assert.Equal(expectedResult, actual);
        }

        [Fact]
        [Trait("Category", "Subtraction")]
        public void Subtract_2_FROM_5_Return_3()
        {
            // Assert
            int num1 = 5;
            int num2 = 2;
            var expected = 3;

            // Act
            var actual = Calculator.Subtraction(num1, num2);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [Trait("Category", "Subtraction")]
        [InlineData(50, 25, 25)]
        [InlineData(50, -25, 75)]
        [InlineData(-50, -50, 0)]
        [InlineData(0, -50, 50)]
        [InlineData(100, 100, 0)]
        [InlineData(-50, 25, -75)]
        public void Subtract_Numbers(double num1, double num2, double expectedResult)
        {
            // Act
            var actual = Calculator.Subtraction(num1, num2);

            // Assert
            Assert.Equal(expectedResult, actual);

        }

        [Fact]
        [Trait("Category", "Divison")]
        public void Divide_10_WITH_2_Return_5()
        {
            // Assert
            int num1 = 10;
            int num2 = 2;
            var expected = 5;

            // Act
            var actual = Calculator.Division(num1, num2);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        [Trait("Category", "Divison")]
        public void Divide_with_0_Throws()
        {
            // Assert
            int num1 = 10;
            int num2 = 0;

            // Act + Assert
            Assert.Throws<ArgumentNullException>(() => Calculator.Division(num1, num2));
        }

        [Theory]
        [Trait("Category", "Divison")]
        [InlineData(20, 2, 10)]
        [InlineData(4, 3, 1.3333333333333333)]
        [InlineData(6, 5, 1.2)]
        [InlineData(-10, 5, -2)]
        [InlineData(82, 4, 20.5)]
        public void Divide_Numbers(double num1, double num2, double expectedResult)
        {
            // Act
            var actual = Calculator.Division(num1, num2);

            // Assert
            Assert.Equal(expectedResult, actual);
        }

        [Fact]
        [Trait("Category", "Multiplication")]
        public void Multiply_3_WITH_7_Return_21()
        {
            // Assert
            int num1 = 3;
            int num2 = 7;
            var expected = 21;

            // Act
            var actual = Calculator.Multiplication(num1, num2);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [Trait("Category", "Multiplication")]
        [InlineData(10, 10, 100)]
        [InlineData(10, -2, -20)]
        [InlineData(6.3, 7.1, 44.73)]
        [InlineData(0, 5, 0)]
        [InlineData(64, 125, 8000)]
        public void Multiply_Numbers(double num1, double num2, double expectedResult)
        {
            // Act
            var actual = Calculator.Multiplication(num1, num2);

            // Assert
            Assert.Equal(expectedResult, actual);
        }

    }
}
