using Ch04Ex02PrimeFactorsLib;

namespace Ch04Ex02PrimeFactorsTests;

public class PrimeFactorsTests
{
    [Theory]
    [InlineData(4, "2 x 2")]
    [InlineData(7, "7")]
    [InlineData(30, "2 x 3 x 5")]
    [InlineData(50, "2 x 5 x 5")]
    public void PrimeFactors_CalculateNumber_ReturnPrimeFactorsString(int number, string expected)
    {
        string actual = PrimeFactorsLib.PrimeFactors(number);

        Assert.Equal(expected, actual);
    }
}
