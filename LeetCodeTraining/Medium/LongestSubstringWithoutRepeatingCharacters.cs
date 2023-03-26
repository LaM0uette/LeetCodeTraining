namespace LeetCodeTraining.Medium;

public class LongestSubstringWithoutRepeatingCharacters
{
    public int LengthOfLongestSubstring(string s)
    {
        if (!CheckConstraints(s)) return 0;

        var max = 0;
        var left = 0;
        var right = 0;
        var charIndices = new Dictionary<char, int>();

        while (right < s.Length)
        {
            var currentChar = s[right];

            if (charIndices.ContainsKey(currentChar) && charIndices[currentChar] >= left)
                left = charIndices[currentChar] + 1;

            charIndices[currentChar] = right;
            max = Math.Max(max, right - left + 1);
            right++;
        }
        return max;
    }

    private static bool CheckConstraints(string s) => !(s.Length > 5 * Math.Pow(10, 4));
}