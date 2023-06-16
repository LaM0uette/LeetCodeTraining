using LeetCodeTraining.Easy;

namespace LeetCodeTrainingTest.Easy;

public class LongestCommonPrefixTest
{
    [Fact]
    public void LongestCommonPrefix_Empty_EmptyString()
    {
        var lst = Array.Empty<string>();
        
        var result = new Solution().LongestCommonPrefix(lst);
        
        Assert.Equal("", result);
    }
    
    [Fact]
    public void LongestCommonPrefix_FlowerFlowFlight_Fl()
    {
        var lst = new[] { "flower","flow","flight" };
        
        var result = new Solution().LongestCommonPrefix(lst);
        
        Assert.Equal("fl", result);
    }
    
    [Fact]
    public void LongestCommonPrefix_DogRacecarCar_EmptyString()
    {
        var lst = new[] { "dog","racecar","car" };
        
        var result = new Solution().LongestCommonPrefix(lst);
        
        Assert.Equal("", result);
    }
}