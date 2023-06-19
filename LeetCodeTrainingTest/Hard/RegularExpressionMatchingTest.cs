using LeetCodeTraining.Hard;

namespace LeetCodeTrainingTest.Hard;

public class RegularExpressionMatchingTest
{
    [Fact]
    public void IsMatch_EmptyEmpty_True()
    {
        const string s = "";
        const string p = "";
        
        var isMatch = new RegularExpressionMatching();
        
        Assert.True(isMatch.IsMatch(s, p));
    }
}