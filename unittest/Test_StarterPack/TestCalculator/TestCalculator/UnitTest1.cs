using System;
using Xunit;

namespace TestCalculator
{
    public class UnitTestCalculator
    {
        
        //Add2 function
        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(-4, -6, -10)]
        [InlineData(-2, 2, 0)]
        [InlineData(int.MinValue, -1, int.MaxValue)]
        public void TestAdd2(int a, int b, int expected)
        {
            Assert.Equal(expected, Calculator.Calculator.Add2(a, b));
        }

        
        //Div function 
        [Theory]
        [InlineData(3, 2, 1)]
        [InlineData(0, 5, 0)]
        [InlineData(4, 4, 1)]
        public void TestDiv(int a, int b, int expected)
        {
            Assert.Equal(expected, Calculator.Calculator.Div(a, b));
        }

        [Fact]
        public void TestThrowDivDivByZero()
        {
            Assert.Throws<DivideByZeroException>((() => Calculator.Calculator.Div(1, 0)));
        }
    }
}