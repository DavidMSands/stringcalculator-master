
namespace StringCalculator;

public class StringCalculatorTests
{
    [Fact]
    public void EmptyStringReturnsZero()
    {
        var calculator = new StringCalculator();

        var result = calculator.Add("");

        Assert.Equal(0, result);
    }

    [Fact]
    public void SingleDigitReturnsItslef()
    {
        var calculator = new StringCalculator();

        var result = calculator.Add("1");

        Assert.Equal(1, result);
    }

    [Fact]
    public void TwoOrMoreDigitReturnSum()
    {
        var calculator = new StringCalculator();

        var result = calculator.Add("1,6");

        Assert.Equal(7, result);
    }

    [Fact]

    public void NewLineSum()
    {
        var calculator = new StringCalculator();

        var result = calculator.Add("1,6\n6");

        Assert.Equal(13, result);
    }

    [Fact]
    public void DefineDelimiter()
    {
        var calculator = new StringCalculator();

        var result = calculator.Add("//;\n1;2");

        Assert.Equal(3, result);
    }
}
