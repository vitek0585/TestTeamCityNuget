using TeamCityTestNuget;
using Xunit;

namespace TestCalculate
{
    public class TestCalc
    {
        [Fact]
        public void SumTest()
        {
            Calculate calc = new Calculate();
            Assert.Equal(5, calc.Sum(4, 1));
        }
        [Fact]
        public void SumTestFail()
        {
            Calculate calc = new Calculate();
            Assert.Equal(5, calc.Sum(2, 1));
        }
    }
}