using System;
using Xunit;
using MyFuntion;

namespace Test_StarterPack
{
    public class UnitTest
    {
        [Fact]
        public void Test_Calculator_Addition()
        {
            Assert.Equal(11, Calculator.Addition(5, 6));
        }
    }
}