using LeetCodeTraining.Medium;

namespace LeetCodeTrainingTest.Medium;

public class LongestPalindromicSubstringTest
{
    private LongestPalindromicSubstring _longestPs = new();

    [Fact]
    public void LongestPalindrome_a_a()
    {
        Assert.Equal("a", _longestPs.LongestPalindrome("a"));
    }
    
    [Fact]
    public void LongestPalindrome_aacabdkacaa_aca()
    {
        Assert.Equal("aca", _longestPs.LongestPalindrome("aacabdkacaa"));
    }

    [Fact]
    public void LongestPalindrome_babad_bab()
    {
        Assert.Equal("bab", _longestPs.LongestPalindrome("babad"));
    }
    
    [Fact]
    public void LongestPalindrome_cbbd_bb()
    {
        Assert.Equal("bb", _longestPs.LongestPalindrome("cbbd"));
    }
    
    [Fact]
    public void LongestPalindrome_babadbabad_bab()
    {
        Assert.Equal("bab", _longestPs.LongestPalindrome("babadbabad"));
    }
    
    [Fact]
    public void LongestPalindrome_01110_01110()
    {
        Assert.Equal("01110", _longestPs.LongestPalindrome("01110"));
    }
    
    [Fact]
    public void LongestPalindrome_011101010_01110()
    {
        Assert.Equal("01110", _longestPs.LongestPalindrome("011101010"));
    }
    
    [Fact]
    public void CheckMaxLength_50_True()
    {
        Assert.True(LongestPalindromicSubstring.CheckMaxLength(50));
    }
    
    [Fact]
    public void CheckMaxLength_1001_False()
    {
        Assert.False(LongestPalindromicSubstring.CheckMaxLength(1001));
    }
}