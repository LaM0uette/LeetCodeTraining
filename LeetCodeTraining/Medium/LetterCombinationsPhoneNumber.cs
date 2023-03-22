namespace LeetCodeTraining.Medium;

public class LetterCombinationsPhoneNumber
{
    public IList<string> LetterCombinations(string digits)
    {
        var lst = new List<string>();

        switch (digits)
        {
            case "2": lst = new List<string> {"a", "b", "c"}; break;
            case "3": lst = new List<string> {"d", "e", "f"}; break;
            case "4": lst = new List<string> {"g", "h", "i"}; break;
            case "5": lst = new List<string> {"j", "k", "l"}; break;
            case "6": lst = new List<string> {"m", "n", "o"}; break;
            case "7": lst = new List<string> {"p", "q", "r", "s"}; break;
            case "8": lst = new List<string> {"t", "u", "v"}; break;
            case "9": lst = new List<string> {"w", "x", "y", "z"}; break;
        }

        return lst;
    }
}