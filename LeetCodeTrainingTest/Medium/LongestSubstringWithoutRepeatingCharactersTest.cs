using LeetCodeTraining.Medium;

namespace LeetCodeTrainingTest.Medium;

public class LongestSubstringWithoutRepeatingCharactersTest
{
    private LongestSubstringWithoutRepeatingCharacters _solution = new();
    private int GetLength(string s) => _solution.LengthOfLongestSubstring(s);

    [Fact]
    private void LengthOfLongestSubstring_bbbbb_1() =>
        Assert.Equal(1, GetLength("bbbbb"));
    
    [Fact]
    private void LengthOfLongestSubstring_abcabcbb_3() =>
        Assert.Equal(3, GetLength("abcabcbb"));
}