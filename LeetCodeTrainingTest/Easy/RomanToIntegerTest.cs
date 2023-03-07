using LeetCodeTraining.Easy;

namespace LeetCodeTrainingTest.Easy;

public class RomanToIntegerTest
{
    /*
     Assert.Equal(3, RomanToInt("III"));
     Assert.Equal(4, RomanToInt("IV"));
     Assert.Equal(9, RomanToInt("IX"));
     Assert.Equal(58, RomanToInt("LVIII"));
     Assert.Equal(1994, RomanToInt("MCMXCIV"));
     */

    private readonly RomanToInteger RomanToInteger = new RomanToInteger();
    
    [Fact]
    public void RomanToInt_Roman_Int()
    {
        Assert.Equal(1, RomanToInteger.RomanToInt("I"));
        Assert.Equal(2, RomanToInteger.RomanToInt("II"));
        Assert.Equal(3, RomanToInteger.RomanToInt("III"));
        Assert.Equal(4, RomanToInteger.RomanToInt("IIII"));
        Assert.Equal(4, RomanToInteger.RomanToInt("IV"));
        Assert.Equal(5, RomanToInteger.RomanToInt("V"));
        Assert.Equal(6, RomanToInteger.RomanToInt("VI"));
        Assert.Equal(7, RomanToInteger.RomanToInt("VII"));
        Assert.Equal(8, RomanToInteger.RomanToInt("VIII"));
        Assert.Equal(9, RomanToInteger.RomanToInt("VIIII"));
        Assert.Equal(9, RomanToInteger.RomanToInt("VIV"));
        Assert.Equal(10, RomanToInteger.RomanToInt("VIIIII"));
        Assert.Equal(10, RomanToInteger.RomanToInt("VV"));
    }
}