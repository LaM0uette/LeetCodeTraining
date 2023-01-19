using LeetCodeTraining.Medium;
using Xunit.Abstractions;

namespace LeetCodeTrainingTest.Medium;

public class ZigzagConversion
{
    #region Statements

    private readonly ITestOutputHelper _print;
    private static string _s = "";

    public ZigzagConversion(ITestOutputHelper print)
    {
        _print = print;
    }

    #endregion

    //
    
    private string GetResult()
    {
        var result = Solution.ZigzagConversion(_s);
        _print.WriteLine($"{result}");

        return result;
    }

    [Fact]
    public void Test1()
    {
        _s = """
    P   A   H   N
    A P L S I I G
    Y   I   R
    """;
        
        var result = GetResult();
        Assert.True(result.Equals("PAHNAPLSIIGYIR"));
    }
    
    [Fact]
    public void Test2()
    {
        _s = """
    P     I    N
    A   L S  I G
    Y A   H R
    P     I
    """;
        
        var result = GetResult();
        Assert.True(result.Equals("PINALSIGYAHRPI"));
    }
}