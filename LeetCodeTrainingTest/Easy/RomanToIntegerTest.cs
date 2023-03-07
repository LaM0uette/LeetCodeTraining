using LeetCodeTraining.Easy;

namespace LeetCodeTrainingTest.Easy;

public class RomanToIntegerTest
{
    private readonly RomanToInteger RomanToInteger = new RomanToInteger();
    
    [Fact]
    public void RomanToInt_Roman_Int()
    {
        Assert.Equal(1, RomanToInteger.RomanToInt("I"));
        Assert.Equal(2, RomanToInteger.RomanToInt("II"));
        Assert.Equal(3, RomanToInteger.RomanToInt("III"));
        Assert.Equal(4, RomanToInteger.RomanToInt("IV"));
        Assert.Equal(5, RomanToInteger.RomanToInt("V"));
        Assert.Equal(6, RomanToInteger.RomanToInt("VI"));
        Assert.Equal(7, RomanToInteger.RomanToInt("VII"));
        Assert.Equal(8, RomanToInteger.RomanToInt("VIII"));
        Assert.Equal(9, RomanToInteger.RomanToInt("IX"));
        Assert.Equal(10, RomanToInteger.RomanToInt("X"));
    }
    
    [Fact]
    public void RomanToInt_BigRoman_BigInt()
    {
        Assert.Equal(30, RomanToInteger.RomanToInt("XXX"));
        Assert.Equal(40, RomanToInteger.RomanToInt("XL"));
        Assert.Equal(50, RomanToInteger.RomanToInt("L"));
        Assert.Equal(80, RomanToInteger.RomanToInt("LXXX"));
        Assert.Equal(90, RomanToInteger.RomanToInt("XC"));
        Assert.Equal(100, RomanToInteger.RomanToInt("C"));
        Assert.Equal(800, RomanToInteger.RomanToInt("DCCC"));
        Assert.Equal(900, RomanToInteger.RomanToInt("CM"));
        Assert.Equal(1000, RomanToInteger.RomanToInt("M"));
    }

    [Fact]
    public void RomanToInt_XLIX_49()
    {
        Assert.Equal(49, RomanToInteger.RomanToInt("XLIX"));
    }
    
    [Fact]
    public void RomanToInt_LVIII_58()
    {
        Assert.Equal(58, RomanToInteger.RomanToInt("LVIII"));
    }
    
    [Fact]
    public void RomanToInt_MCMXCIV_1994()
    {
        Assert.Equal(1994, RomanToInteger.RomanToInt("MCMXCIV"));
    }
    
    [Fact]
    public void CheckLength_Length_Ok()
    {
        Assert.True(RomanToInteger.CheckLength("IX"));
    }
    
    [Fact]
    public void CheckLength_Length_False()
    {
        Assert.False(RomanToInteger.CheckLength("IXVIXIVIXIVIXIVIXIVIXVIXIVXI"));
    }

    [Fact]
    public void CheckValidString_XIV_Ok()
    {
        Assert.True(RomanToInteger.CheckValidString("XIV"));
    }
    
    [Fact]
    public void CheckValidString_51etTest_Nok()
    {
        Assert.False(RomanToInteger.CheckValidString("51"));
        Assert.False(RomanToInteger.CheckValidString("Test"));
    }
    
    [Fact]
    public void CheckMaxRomanNumber_117_Ok()
    {
        Assert.True(RomanToInteger.CheckMaxRomanNumber(117));
    }
    
    [Fact]
    public void CheckMaxRomanNumber_4000_Nok()
    {
        Assert.False(RomanToInteger.CheckMaxRomanNumber(4000));
    }
}