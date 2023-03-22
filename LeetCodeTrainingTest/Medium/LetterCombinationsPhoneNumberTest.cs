using LeetCodeTraining.Medium;

namespace LeetCodeTrainingTest.Medium;

public class LetterCombinationsPhoneNumberTest
{
    private static readonly LetterCombinationsPhoneNumber _combinations = new();
    private static IList<string> GetCombinations(string digits) => 
        _combinations.LetterCombinations(digits);

    [Fact]
    public void LetterCombinations_null_()
    {
        Assert.Equal(new List<string>(), GetCombinations(""));
    }
    
    [Fact]
    public void LetterCombinations__() =>
        Assert.Equal(new List<string>(), GetCombinations(""));
    
    [Fact]
    public void LetterCombinations_0_() =>
        Assert.Equal(new List<string>(), GetCombinations("0"));
    
    [Fact]
    public void LetterCombinations_1_() =>
        Assert.Equal(new List<string>(), GetCombinations("1"));
    
    [Fact]
    public void LetterCombinations_2_abc() =>
        Assert.Equal(new List<string>{"a", "b", "c"}, GetCombinations("2"));
    
    [Fact]
    public void LetterCombinations_3_def() =>
        Assert.Equal(new List<string>{"d", "e", "f"}, GetCombinations("3"));
    
    [Fact]
    public void LetterCombinations_4_ghi() =>
        Assert.Equal(new List<string>{"g", "h", "i"}, GetCombinations("4"));
    
    [Fact]
    public void LetterCombinations_5_jkl() =>
        Assert.Equal(new List<string>{"j", "k", "l"}, GetCombinations("5"));
    
    [Fact]
    public void LetterCombinations_6_mno() =>
        Assert.Equal(new List<string>{"m", "n", "o"}, GetCombinations("6"));
    
    [Fact]
    public void LetterCombinations_7_pqrs() =>
        Assert.Equal(new List<string>{"p", "q", "r", "s"}, GetCombinations("7"));
    
    [Fact]
    public void LetterCombinations_8_tuv() =>
        Assert.Equal(new List<string>{"t", "u", "v"}, GetCombinations("8"));
    
    [Fact]
    public void LetterCombinations_9_wxyz() =>
        Assert.Equal(new List<string>{"w", "x", "y", "z"}, GetCombinations("9"));
    
    
}