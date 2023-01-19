using LeetCodeTraining.Hard;
using Xunit.Abstractions;

namespace LeetCodeTrainingTest.Hard;

public class FindMedianSortedArrays
{
    private readonly ITestOutputHelper _print;
    private static int[] _nums1 = null!;
    private static int[] _nums2 = null!;

    public FindMedianSortedArrays(ITestOutputHelper print)
    {
        _print = print;
    }

    private double GetResult()
    {
        var result = Solution.FindMedianSortedArrays(_nums1, _nums2);
        _print.WriteLine($"{result}");

        return result;
    }

    [Fact]
    public void Test1()
    {
        _nums1 = new []{1, 3};
        _nums2 = new []{2};

        var r = GetResult();
        Assert.True(r.Equals(2));
    }
    
    [Fact]
    public void Test2()
    {
        _nums1 = new []{1, 2};
        _nums2 = new []{3, 4};

        var r = GetResult();
        Assert.True(r.Equals(2.5));
    }
}