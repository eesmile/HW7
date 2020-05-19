using System;
using System.Linq;
using Xunit;

namespace ConsoleApp10.Test
{
    public class UnitTest1
    {
        [Fact]
        public void TestPlus()
        {
            Calc calc = new Calc();
            double a = 4;
            double b = 9;
            double act = calc.Plus(a, b);
            double exp = 13;
            Assert.Equal(exp, act);
        }
        [Fact]
        public void TestMinus()
        {
            Calc calc = new Calc();
            double a = 5;
            double b = 1;
            double act = calc.Minus(a, b);
            double exp = 4;
            Assert.Equal(exp, act);
        }
        [Theory]
        [InlineData(9,3,27)]
        [InlineData(10, 3, 30)]
        [InlineData(9, 3, 15)]
        public void TestMulti(double a, double b, double exp)
        {
            Calc calc = new Calc();
            double act = calc.Multi(a, b);
            Assert.Equal(exp, act);
        }
        [Theory]
        [InlineData(9, 3, 3)]
        [InlineData(8, 3, 2)]
        [InlineData(8, 2, 4)]
        public void TestDiv(double a, double b, double exp)
        {
            Calc calc = new Calc();
            double act = calc.Div(a, b);
            Assert.Equal(exp, act);
        }
        [Theory]
        [InlineData(9, 3)]
        [InlineData(2, 3)]
        [InlineData(25, 5)]
        public void TestSqrt(double a, double exp)
        {
            Calc calc = new Calc();
            double act = calc.Sqrt(a);
            Assert.Equal(exp, act);
        }
    }
}
