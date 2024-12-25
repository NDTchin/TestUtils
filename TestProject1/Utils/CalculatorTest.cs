using WebApplication2.Utils;
using Xunit;
namespace TestProject1.Utils;

public class CalculatorTest
{
    [Fact]
    public void Add()
    {
        Calculator calculator = new Calculator();
        var result = calculator.Add(2, 3);
        Assert.Equal(5, result);
    }
    [Fact]
    public void AddWrong()
    {
        Calculator calculator = new Calculator();
        var result = calculator.Add(2, 3);
        Assert.NotEqual(6, result);
        Assert.True(result == 5);
    }

    [Fact]
    public void DevideByZero()
    {
        Calculator calculator = new Calculator();
        Assert.Throws<DivideByZeroException>(() => calculator.Devide(2, 3));
    }
}