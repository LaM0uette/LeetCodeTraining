using System.Text.RegularExpressions;

namespace LeetCodeTraining.Medium;

public static partial class Solution
{
    public static string ZigzagConversion(string s)
    {
        const string pattern = @"[ 
]";
        const string substitution = @"";
        const RegexOptions options = RegexOptions.Multiline;
        
        var regex = new Regex(pattern, options);
        
        return regex.Replace(s, substitution);
    }
}