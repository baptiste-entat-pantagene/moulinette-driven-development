using Xunit;
using Calculator;

namespace TestCalculator
{
    public class 
        UnitTestCalculator
    {
        [Fact]
        public void TestAdd2()
        {
            Assert.Equal(11, Calculator.Calculator.Add2(5, 6));
        }
    }
}