using System.Text.RegularExpressions;

namespace LeetCodeTraining.Medium;

public class StringToInteger
{
    public int MyAtoiRegex(string s) {
        
        var m = Regex.Match(s.TrimStart(), @"^([-+]?\d+)");
        
        if (!m.Success) return 0;
        if (int.TryParse(m.Groups[0].Value, out var result)) return result;
        
        return m.Groups[0].Value.StartsWith("-") ? int.MinValue : int.MaxValue;
    }
    
    public int MyAtoi(string s)
    {
        if (s.Equals("")) return 0;
        
        int i = 0, sign = 1, lenght = s.Length;
        long result = 0;

        while (i < lenght && s[i].Equals(' ')) i++;

        if (s[i].Equals('-') || s[i].Equals('+'))
            sign = s[i++].Equals('-') ? -1 : 1;

        while (i < lenght && char.IsDigit(s[i]))
        {
            result = result * 10 + (s[i++] - '0');
            
            switch (result * sign)
            {
                case > int.MaxValue: return int.MaxValue;
                case < int.MinValue: return int.MinValue;
            }
        }

        return (int)(result * sign);
    }
}