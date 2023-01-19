namespace LeetCodeTraining.Hard;

public static partial class Solution
{
    public static double FindMedianSortedArrays(IEnumerable<int> nums1, IEnumerable<int> nums2)
    {
        var nums = nums1.Union(nums2).ToArray();
        Array.Sort(nums);

        var n = nums.Length;
        var d = Math.Floor((double)n/2);

        return (n % 2).Equals(0) ? (double)(nums[(int)d-1] + nums[(int)d])/2 : nums[(int)d];
    }
}