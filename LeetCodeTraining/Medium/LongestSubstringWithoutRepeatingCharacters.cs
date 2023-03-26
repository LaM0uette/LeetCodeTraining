using System.Text.RegularExpressions;

namespace LeetCodeTraining.Medium;

public class LongestSubstringWithoutRepeatingCharacters
{
    public int LengthOfLongestSubstring(string s)
    {
        if (!CheckConstraints(s)) return 0;
        
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
    
    static bool CheckConstraints(string s)
    {
        // Vérifiez que la longueur de la chaîne est comprise entre 0 et 5 * 10^4
        if (s.Length < 0 || s.Length > 5 * Math.Pow(10, 4)) 
            return false;

        // Vérifiez que la chaîne contient uniquement des lettres anglaises, des chiffres, des symboles et des espaces
        var validCharacters = new Regex(@"^[a-zA-Z0-9\s!@#$%^&*()_+{}|;':"",./<>?`~[\]\\-]*$");
        return validCharacters.IsMatch(s);
    }
}