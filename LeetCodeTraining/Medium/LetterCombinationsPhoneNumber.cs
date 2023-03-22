namespace LeetCodeTraining.Medium;

public class LetterCombinationsPhoneNumber
{
    private Dictionary<string, List<string>> digitToListMap = new(){
        { "2", new List<string> {"a", "b", "c"} },
        { "3", new List<string> {"d", "e", "f"} },
        { "4", new List<string> {"g", "h", "i"} },
        { "5", new List<string> {"j", "k", "l"} },
        { "6", new List<string> {"m", "n", "o"} },
        { "7", new List<string> {"p", "q", "r", "s"} },
        { "8", new List<string> {"t", "u", "v"} },
        { "9", new List<string> {"w", "x", "y", "z"} }
    };

    public IList<string> LetterCombinations(string digits)
    {
        return GetNumberList(digits);
    }

    private IList<string> GetNumberList(string digit) => 
        digitToListMap.TryGetValue(digit, out var lst) ? lst : new List<string>();
}