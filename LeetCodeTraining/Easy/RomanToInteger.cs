using System.Text.RegularExpressions;

namespace LeetCodeTraining.Easy;

public class RomanToInteger
{
    private const string pattern = @"(?:IV|IX|XL|XC|CD|CM|I|V|X|L|C|D|M)";
    private const string validPattern = @"(?:I|V|X|L|C|D|M)";
    
    public int RomanToInt(string s)
    {
        if (!CheckLength(s)) throw new Exception();
        if (!CheckValidString(s)) throw new Exception();
        
        return RegexRomanToInt(s);
    }

    public static bool CheckLength(string s)
    {
        return s.Length is >= 1 and <= 15;
    }
    
    public static bool CheckValidString(string s)
    {
        return Regex.IsMatch(s, validPattern, RegexOptions.Multiline);
    }

    private static int RegexRomanToInt(string s)
    {
        var num = 0;
        
        foreach (Match m in Regex.Matches(s, pattern, RegexOptions.Multiline))
        {
            num += GetRomanToInt(m.Value);
        }

        return num;
    }

    private static int GetRomanToInt(string s)
    {
        return s switch
        {
            "I" => 1,
            "IV" => 4,
            "V" => 5,
            "IX" => 9,
            "X" => 10,
            "XL" => 40,
            "L" => 50,
            "XC" => 90,
            "C" => 100,
            "CD" => 400,
            "D" => 500,
            "CM" => 900,
            "M" => 1000,
            _ => throw new ArgumentOutOfRangeException(nameof(s), s, null)
        };
    }
}