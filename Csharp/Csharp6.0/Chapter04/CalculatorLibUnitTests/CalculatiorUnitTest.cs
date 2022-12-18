using Xunit;
using Packt;

namespace CalculatorLibUnitTests;

public class UnitTest1
{
    [Fact]
    public void TestAdding2and2()
    {
        double a = 2;
        double b = 2;
        double expected = 4;
        Calculator calc = new();

        double actual = calc.Add(a, b);

        Assert.Equal(expected, actual);

    }

    [Fact]
    public void TestAdding2and3()
    {
        double a = 2;
        double b = 3;
        double expected = 5;
        Calculator calc = new();

        double actual = calc.Add(a, b);

        Assert.Equal(expected, actual);
    }

}