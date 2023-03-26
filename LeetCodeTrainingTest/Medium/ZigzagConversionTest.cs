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
    
    [Fact]
    private void Convert_PAYPALISHIRING3_PAHNAPLSIIGYIR()
    {
        Assert.Equal(
            "PAHNAPLSIIGYIR", 
            GetResult("PAYPALISHIRING", 3)
        );
    }
    
    [Fact]
    private void Convert_PAYPALISHIRING20_PAYPALISHIRING()
    {
        Assert.Equal(
            "PAYPALISHIRING", 
            GetResult("PAYPALISHIRING", 20)
        );
    }
    
    [Fact]
    private void Convert_AAABBBCCCDDD4_ACABCDABCDBD()
    {
        Assert.Equal(
            "ACABCDABCDBD", 
            GetResult("AAABBBCCCDDD", 4)
        );
    }
    
    [Fact]
    private void Convert_Spé5_Spé()
    {
        Assert.Equal(
            "aYBxzc#!@2", 
            GetResult("aBc!2@#xYz", 5)
        );
    }
    
    [Fact]
    private void Convert_Hello_World4_HWeolordll()
    {
        Assert.Equal(
            "HWe olordll", 
            GetResult("Hello World", 4)
        );
    }
}