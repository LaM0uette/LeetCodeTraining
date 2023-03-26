namespace LeetCodeTraining.Medium;

public class LongestSubstringWithoutRepeatingCharacters
{
    public int LengthOfLongestSubstring(string s)
    {
        var lst = new List<char>();
        var max = 0;
        
        foreach (var sChar in s)
        {
            lst.Clear();
            
            for (var i = s.IndexOf(sChar); i < s.Length; i++)
            {
                if (lst.Any(c => c.Equals(s[i]))) break;
                lst.Add(s[i]);
            }
            
            var listLength = lst.Count;
            if (listLength > max) max = listLength;
        }

        return max;
    }
}