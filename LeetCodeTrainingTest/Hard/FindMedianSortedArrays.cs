using LeetCodeTraining.Hard;
using Xunit.Abstractions;

namespace LeetCodeTrainingTest.Hard;

public class FindMedianSortedArrays
{
    private readonly ITestOutputHelper _print;
    private static int[]? _nums1;
    private static int[]? _nums2;

    public FindMedianSortedArrays(ITestOutputHelper print)
    {
        _print = print;
    }

    [Fact]
    public void Test1()
    {
        _nums1 = new []{1, 3};
        _nums2 = new []{2};

        var result = Solution.FindMedianSortedArrays(_nums1, _nums2);
        _print.WriteLine($"{result}");
    }
}