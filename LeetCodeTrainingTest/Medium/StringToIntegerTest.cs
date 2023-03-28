using LeetCodeTraining.Medium;

namespace LeetCodeTrainingTest.Medium;

public class StringToIntegerTest
{
    private StringToInteger _stringToInteger = new();
    private int GetAtoi(string s) => _stringToInteger.MyAtoi(s);
    
    [Fact]
    private void MyAtoi_WithEmptyString_ReturnsZero()
    {
        Assert.Equal(0, GetAtoi(""));
    }
    
    [Fact]
    private void MyAtoi_Space42_42()
    {
        Assert.Equal(42, GetAtoi(" 42"));
        Assert.Equal(-42, GetAtoi(" -42"));
        Assert.Equal(+42, GetAtoi(" +42"));
    }
    
    [Fact]
    private void MyAtoi_SpaceArround101_101()
    {
        Assert.Equal(101, GetAtoi(" 101 "));
        Assert.Equal(-101, GetAtoi(" -101 "));
        Assert.Equal(+101, GetAtoi(" +101 "));
    }
    
    [Fact]
    private void MyAtoi_OnlyChar_0()
    {
        Assert.Equal(0, GetAtoi("wordsonly"));
        Assert.Equal(0, GetAtoi(" wordsonly"));
        Assert.Equal(0, GetAtoi(" wordsonly "));
    }
    
    [Fact]
    private void MyAtoi_CharInt_Int()
    {
        Assert.Equal(4193, GetAtoi("4193 with words"));
        Assert.Equal(0, GetAtoi("words and 987"));
        Assert.Equal(-42, GetAtoi(" -42abc "));
    }
    
    [Fact]
    private void MyAtoi_DoubleSigns1_1()
    {
        Assert.Equal(0, GetAtoi("-+1"));
        Assert.Equal(0, GetAtoi("+-1"));
        Assert.Equal(0, GetAtoi("++1"));
        Assert.Equal(0, GetAtoi("--1"));
        Assert.Equal(0, GetAtoi(" -+1"));
        Assert.Equal(0, GetAtoi(" +-1"));
        Assert.Equal(0, GetAtoi(" ++1"));
        Assert.Equal(0, GetAtoi(" --1"));
    }
    
    [Fact]
    private void MyAtoi_LimitInt32_0()
    {
        Assert.Equal(2147483647, GetAtoi("2147483648"));
        Assert.Equal(-2147483648, GetAtoi("-2147483649"));
    }
    
    [Fact]
    private void MyAtoi_LimitInt32_Int()
    {
        Assert.Equal(2147483647, GetAtoi("2147483647"));
        Assert.Equal(-2147483648, GetAtoi("-2147483648"));
    }
}