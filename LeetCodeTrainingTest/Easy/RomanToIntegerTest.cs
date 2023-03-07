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
    public void RomanToInt_III_3()
    {
        Assert.Equal(3, RomanToInteger.RomanToInt("III"));
    }
}