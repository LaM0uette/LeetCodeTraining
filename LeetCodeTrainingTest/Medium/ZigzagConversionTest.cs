using LeetCodeTraining.Medium;

namespace LeetCodeTrainingTest.Medium;

public class ZigzagConversionTest
{
    private ZigzagConversion _zzConvert = new();
    private string GetResult(string s, int numRows) => 
        _zzConvert.Convert(s, numRows);

    [Fact]
    private void Convert_null123_null()
    {
        Assert.Equal("", GetResult("", 1));
        Assert.Equal("", GetResult("", 2));
        Assert.Equal("", GetResult("", 3));
    }
    
    [Fact]
    private void Convert_A123_A()
    {
        Assert.Equal("A", GetResult("A", 1));
        Assert.Equal("A", GetResult("A", 2));
        Assert.Equal("A", GetResult("A", 3));
    }
    
    [Fact]
    private void Convert_AB2_AB()
    {
        Assert.Equal("AB", GetResult("AB", 2));
    }
    
    [Fact]
    private void Convert_AB3_AB()
    {
        Assert.Equal("AB", GetResult("AB", 3));
    }
    
    [Fact]
    private void Convert_PAYPALISHIRING1_PAYPALISHIRING()
    {
        Assert.Equal(
            "PAYPALISHIRING", 
            GetResult("PAYPALISHIRING", 1)
            );
    }
    
    [Fact]
    private void Convert_PAYPALISHIRING2_PYAIHRNAPLSIIG()
    {
        Assert.Equal(
            "PYAIHRNAPLSIIG", 
            GetResult("PAYPALISHIRING", 2)
            );
    }
}