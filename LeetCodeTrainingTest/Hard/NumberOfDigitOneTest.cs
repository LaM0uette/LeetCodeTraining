using LeetCodeTraining.Hard;

namespace LeetCodeTrainingTest.Hard;

public class NumberOfDigitOneTest
{
    private NumberOfDigitOne _numberOfDigitOne = new();
    private int GetD1(int n) => _numberOfDigitOne.CountDigitOne(n);

    [Fact]
    private void CountDigitOne_0_0()
    {
        Assert.Equal(0, GetD1(0));
    }
    
    [Fact]
    private void CountDigitOne_1_1()
    {
        Assert.Equal(1, GetD1(1));
    }
    
    [Fact]
    private void CountDigitOne_5_1()
    {
        Assert.Equal(1, GetD1(5));
    }
    
    [Fact]
    private void CountDigitOne_m5_1()
    {
        Assert.Equal(0, GetD1(-5));
    }
    
    [Fact]
    private void CountDigitOne_10_2()
    {
        Assert.Equal(2, GetD1(10));
    }
    
    [Fact]
    private void CountDigitOne_13_6()
    {
        Assert.Equal(6, GetD1(13));
    }
    
    [Fact]
    private void CountDigitOne_15_8()
    {
        Assert.Equal(8, GetD1(15));
    }
}