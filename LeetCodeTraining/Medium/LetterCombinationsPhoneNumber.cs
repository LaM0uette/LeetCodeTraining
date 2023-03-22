using System.Text;

namespace LeetCodeTraining.Medium;

public class LetterCombinationsPhoneNumber
{
    private Dictionary<char, string> digitToLetters = new Dictionary<char, string> {
        {'2', "abc"},
        {'3', "def"},
        {'4', "ghi"},
        {'5', "jkl"},
        {'6', "mno"},
        {'7', "pqrs"},
        {'8', "tuv"},
        {'9', "wxyz"},
    };

    public IList<string> LetterCombinations(string digits)
    {
        var result = new List<string>();
        
        if (string.IsNullOrEmpty(digits)) return result;
        
        Backtrack(digits, 0, new StringBuilder(), result);
        
        return result;
    }

    private void Backtrack(string digits, int index, StringBuilder current, ICollection<string> result)
    {
        if (digits.Length.Equals(index))
        {
            result.Add(current.ToString());
            return;
        }

        var digit = digits[index];
        
        if (!digitToLetters.TryGetValue(digit, out var letters)) return;
        
        foreach (var letter in letters)
        {
            current.Append(letter);
            Backtrack(digits, index+1, current, result);
            current.Remove(current.Length - 1, 1);
        }
    }
}