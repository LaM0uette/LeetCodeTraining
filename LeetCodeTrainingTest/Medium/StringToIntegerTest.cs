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
}