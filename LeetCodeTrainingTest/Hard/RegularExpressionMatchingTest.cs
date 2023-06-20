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
    
    [Fact]
    public void IsMatch_aEmpty_False()
    {
        const string s = "a";
        const string p = "";
        
        var isMatch = new RegularExpressionMatching();
        
        Assert.False(isMatch.IsMatch(s, p));
    }
    
    [Fact]
    public void IsMatch_aa_True()
    {
        const string s = "a";
        const string p = "a";
        
        var isMatch = new RegularExpressionMatching();
        
        Assert.True(isMatch.IsMatch(s, p));
    }
    
    [Fact]
    public void IsMatch_ab_False()
    {
        const string s = "a";
        const string p = "b";
        
        var isMatch = new RegularExpressionMatching();
        
        Assert.False(isMatch.IsMatch(s, p));
    }
    
    [Fact]
    public void IsMatch_aDot_True()
    {
        const string s = "a";
        const string p = ".";
        
        var isMatch = new RegularExpressionMatching();
        
        Assert.True(isMatch.IsMatch(s, p));
    }
    
    [Fact]
    public void IsMatch_aaaaaa_True()
    {
        const string s = "aaa";
        const string p = "aaa";
        
        var isMatch = new RegularExpressionMatching();
        
        Assert.True(isMatch.IsMatch(s, p));
    }
    
    [Fact]
    public void IsMatch_aaaaEE_True()
    {
        const string s = "aaa";
        const string p = "a*";
        
        var isMatch = new RegularExpressionMatching();
        
        Assert.True(isMatch.IsMatch(s, p));
    }
    
    [Fact]
    public void IsMatch_aaabEE_False()
    {
        const string s = "aaa";
        const string p = "b*";
        
        var isMatch = new RegularExpressionMatching();
        
        Assert.False(isMatch.IsMatch(s, p));
    }
    
    [Fact]
    public void IsMatch_abab_True()
    {
        const string s = "ab";
        const string p = "ab";
        
        var isMatch = new RegularExpressionMatching();
        
        Assert.True(isMatch.IsMatch(s, p));
    }
}