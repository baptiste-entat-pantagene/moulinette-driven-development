using System;
using Xunit;
using ConsoleApp1;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal(4, 4);
        }

        [Fact]
        public void Test_Add2()
        {
            Calculator cal = new Calculator();
            Assert.Equal(3, cal.Add2(2, 1));
        }
    }
}