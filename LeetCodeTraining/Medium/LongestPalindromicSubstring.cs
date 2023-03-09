namespace LeetCodeTraining.Medium;

public class LongestPalindromicSubstring
{
    public string LongestPalindrome(string s)
    {
        if (!CheckMaxLength(s.Length)) throw new Exception();
        
        var idx = 0;
        var i1 = 0;
        var i2 = 0;
        
        foreach (var sChar in s)
        {
            var inMax = 0;
            
            for (var i = idx+1; i < s.Length; i++)
            {
                if (s[i].Equals(sChar))
                {
                    inMax = i + 1 - idx;
                }
            }
            
            if (inMax > i2)
            {
                i1 = idx;
                i2 = inMax;
            };
            
            idx++;
        }
        
        return s.Substring(i1, i2);
    }
    
    public bool CheckMaxLength(int length)
    {
        return length is >= 1 and <= 1000;
    }
}