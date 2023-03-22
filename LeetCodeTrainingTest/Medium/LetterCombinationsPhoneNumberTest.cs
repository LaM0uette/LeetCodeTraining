using LeetCodeTraining.Medium;

namespace LeetCodeTrainingTest.Medium;

public class LetterCombinationsPhoneNumberTest
{
    private static readonly LetterCombinationsPhoneNumber _combinations = new();
    public static IList<string> GetCombinations(string digits) => 
        _combinations.LetterCombinations(digits);

    [Fact]
    public void LetterCombinations_null_()
    {
        Assert.Equal(new List<string>(), GetCombinations(""));
    }
}