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
        public void Add_2_And_5_Return_7()
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
        [InlineData(50.2, 50, 100.2)]
        [InlineData(13, 7, 20)]
        [InlineData(5, -1, 4)]
        [InlineData(-5, 5, 0)]
        [InlineData(1, 0, 1)]
        [InlineData(-5, -5, -10)]
        public void Add_Numbers(decimal num1, decimal num2, decimal expectedResult)
        {
            // Act
            var actual = Calculator.Addition(num1, num2);

            // Assert
            Assert.Equal(expectedResult, actual);
        }

        [Fact]
        [Trait("Category", "Subtraction")]
        public void Subtract_2_From_5_Return_3()
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
        [InlineData(50.2, 25, 25.2)]
        [InlineData(50, -25, 75)]
        [InlineData(-50, -50, 0)]
        [InlineData(0, -50, 50)]
        [InlineData(100, 100, 0)]
        [InlineData(-50, 25, -75)]
        public void Subtract_Numbers(decimal num1, decimal num2, decimal expectedResult)
        {
            // Act
            var actual = Calculator.Subtraction(num1, num2);

            // Assert
            Assert.Equal(expectedResult, actual);

        }

        [Fact]
        [Trait("Category", "Divison")]
        public void Divide_10_With_2_Return_5()
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
            Assert.Throws<ArgumentException>(() => Calculator.Division(num1, num2));
        }

        [Theory]
        [Trait("Category", "Divison")]
        [InlineData(20, 2, 10)]
        [InlineData(4, 3, 1.33333)]
        [InlineData(6, 5, 1.2)]
        [InlineData(-10, 5, -2)]
        [InlineData(82, 4, 20.5)]
        public void Divide_Numbers(decimal num1, decimal num2, decimal expectedResult)
        {
            // Act
            var actual = Calculator.Division(num1, num2);

            // Assert
            Assert.Equal(expectedResult, actual);
        }

        [Fact]
        [Trait("Category", "Multiplication")]
        public void Multiply_3_With_7_Return_21()
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
        public void Multiply_Numbers(decimal num1, decimal num2, decimal expectedResult)
        {
            // Act
            var actual = Calculator.Multiplication(num1, num2);

            // Assert
            Assert.Equal(expectedResult, actual);
        }

        [Fact]
        [Trait("Category", "User input")]
        public void UserInput_String_Return_Parsed_To_Decimal()
        {
            // Arrange
            string testInput = "3,2";

            // Act
            var actual = Calculator.UserInput(testInput);

            // Assert
            Assert.IsType<decimal>(actual);
        }

        [Theory]
        [Trait("Category", "User input")]
        [InlineData("5,1", 5.1)]
        [InlineData("-1000", -1000)]
        [InlineData("0,4", 0.4)]
        [InlineData("-0,4", -0.4)]
        [InlineData("0", 0)]
        public void UserInput_Test(string testinput, decimal expectedResult)
        {
            // Act + Assert
            Assert.Equal(expectedResult, Calculator.UserInput(testinput));
        }

        [Fact]
        [Trait("Category", "User input")]
        public void UserInput_Not_A_Number_Throws()
        {
            // Assert
            string testInput = "a";

            // Act + Assert
            Assert.Throws<ArgumentException>(() => Calculator.UserInput(testInput));
        }

        [Fact]
        [Trait("Category", "Print result")]
        public void PrintResult_10_Divided_With_5_Is_2()
        {
            // Arrange
            decimal testNum1 = 10;
            decimal testNum2 = 5;
            decimal calculationResult = 2;
            string calcType = "/";
            var expected = "10 / 5 = 2";

            // Act
            var actual = Calculator.PrintResult(testNum1, testNum2, calculationResult, calcType);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [Trait("Category", "Print result")]
        [InlineData(100,13,113,"+", "100 + 13 = 113")]
        [InlineData(100,13,87,"-", "100 - 13 = 87")]
        [InlineData(0,13,0,"*", "0 * 13 = 0")]
        [InlineData(-50,-50,0,"-", "-50 - -50 = 0")]
        [InlineData(20,5,4,"/", "20 / 5 = 4")]
        public void PrintResult_Test(decimal num1, decimal num2, decimal calculationResult, string calcType, string expectedResult)
        {
            // Act + Assert
            Assert.Equal(expectedResult, Calculator.PrintResult(num1, num2, calculationResult, calcType));
        }

        [Fact]
        [Trait("Category", "Print all calculations")]
        public void PrintAllCalculations_Return_4()
        {
            // Arrange
            List<string> testList = new List<string>() { "1 + 1 = 2", 
                "2 - 2 = 0", 
                "10 / 2 = 5", 
                "10 * 10 = 100" };
            var expected = 4;

            // Act
            var actual = Calculator.PrintAllCalculations(testList);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
