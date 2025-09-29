using HomeEnergyApi.Services;

public class MathTests
{
    [Fact]
    public void ShouldReturnCorrectRomanNumeralFor1()
    {
        var result = new MathService().ConvertToRomanNumeral(1);

        Assert.Equal("I", result);
    }

    [Fact]
    public void ShouldReturnCorrectRomanNumeralFor483()
    {
        var result = new MathService().ConvertToRomanNumeral(483);

        Assert.Equal("CDLXXXIII", result);
    }

    [Fact]
    public void ShouldReturnEmptyStringWhenIntegerIsOutOfRange()
    {
        var result = new MathService().ConvertToRomanNumeral(-1);

        Assert.Equal("", result);
    }
}