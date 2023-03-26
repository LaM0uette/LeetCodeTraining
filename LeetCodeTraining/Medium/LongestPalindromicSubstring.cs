namespace LeetCodeTraining.Medium;

public class LongestPalindromicSubstring
{
    public string LongestPalindrome(string s)
    {
        if (!CheckMaxLength(s.Length)) return s;

        var start = 0;
        var maxLength = 1;

        for (var i = 0; i < s.Length; i++)
        {
            var len1 = ExpandAroundCenter(s, i, i);
            var len2 = ExpandAroundCenter(s, i, i + 1);
            var len = Math.Max(len1, len2);

            if (len <= maxLength) continue;
            
            start = i - (len - 1) / 2;
            maxLength = len;
        }
        return s.Substring(start, maxLength);
    }

    private static int ExpandAroundCenter(string s, int left, int right)
    {
        while (left >= 0 && right < s.Length && s[left] == s[right])
        {
            left--;
            right++;
        }
        return right - left - 1;
    }
    
    public static bool CheckMaxLength(int length) => length is > 1 and <= 1000;
}