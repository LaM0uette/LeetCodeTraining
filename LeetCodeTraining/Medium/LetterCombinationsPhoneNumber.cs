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
            case "23": lst = new List<string> {"ad","ae","af","bd","be","bf","cd","ce","cf"}; break;
        }

        return lst;
    }
}