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
}