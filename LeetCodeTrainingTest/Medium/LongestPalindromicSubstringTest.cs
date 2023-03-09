using LeetCodeTraining.Medium;

namespace LeetCodeTrainingTest.Medium;

public class LongestPalindromicSubstringTest
{
    private LongestPalindromicSubstring _longestPs = new();
    
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
    public void LongestPalindrome_babadbabad_babadbab()
    {
        Assert.Equal("babadbab", _longestPs.LongestPalindrome("babadbabad"));
    }
    
    [Fact]
    public void LongestPalindrome_01110_01110()
    {
        Assert.Equal("01110", _longestPs.LongestPalindrome("01110"));
    }
    
    [Fact]
    public void LongestPalindrome_011101010_011101010()
    {
        Assert.Equal("011101010", _longestPs.LongestPalindrome("011101010"));
    }
}