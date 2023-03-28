using System.Text.RegularExpressions;

namespace LeetCodeTraining.Medium;

public class StringToInteger
{
    public int MyAtoi(string s) {
        
        var m = Regex.Match(s.TrimStart(), @"^([-+]?\d+)");
        
        if (!m.Success) return 0;
        if (int.TryParse(m.Groups[0].Value, out var result)) return result;
        
        return m.Groups[0].Value.StartsWith("-") ? int.MinValue : int.MaxValue;
    }
}