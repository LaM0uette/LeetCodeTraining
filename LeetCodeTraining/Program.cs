using LeetCodeTraining.Medium;

namespace LeetCodeTraining;

public static class Program
{
    public static void Main()
    {
        var longestPs = new LongestPalindromicSubstring();
        var s = longestPs.LongestPalindrome("01110");
        
        Console.WriteLine(s);
    }
}