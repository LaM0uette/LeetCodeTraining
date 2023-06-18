using LeetCodeTraining.Easy;

namespace LeetCodeTrainingTest.Easy;

public class ValidParenthesesTest
{
    [Fact]
    public void IsValid_EmptyString_False()
    {
        const string s = "";
        var validParentheses = new ValidParentheses();
        
        var isValid = validParentheses.IsValid(s);
        
        Assert.False(isValid);
    }
    
    [Fact]
    public void IsValid_PoPf_True()
    {
        const string s = "()";
        var validParentheses = new ValidParentheses();
        
        var isValid = validParentheses.IsValid(s);
        
        Assert.True(isValid);
    }
    
    [Fact]
    public void IsValid_PoPo_False()
    {
        const string s = "((";
        var validParentheses = new ValidParentheses();
        
        var isValid = validParentheses.IsValid(s);
        
        Assert.False(isValid);
    }
}