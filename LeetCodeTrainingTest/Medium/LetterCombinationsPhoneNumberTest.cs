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
    public void LetterCombinations_2_abc()
    {
        var lst = new List<string>{"a", "b", "c"};
        Assert.Equal(lst, GetCombinations("2"));
    }
    
    [Fact]
    public void LetterCombinations_3_def()
    {
        var lst = new List<string>{"d", "e", "f"};
        Assert.Equal(lst, GetCombinations("3"));
    }
}