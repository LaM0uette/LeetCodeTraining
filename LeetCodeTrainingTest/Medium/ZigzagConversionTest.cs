using LeetCodeTraining.Medium;

namespace LeetCodeTrainingTest.Medium;

public class ZigzagConversionTest
{
    private ZigzagConversion _zzConvert = new();
    private string GetResult(string s, int numRows) => 
        _zzConvert.Convert(s, numRows);

    [Fact]
    private void Convert_null1_null()
    {
        Assert.Equal("", GetResult("", 1));
    }
}