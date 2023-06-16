namespace LeetCodeTraining.Easy;

public class Solution
{
    public string LongestCommonPrefix(string[] lst)
    {
        if (lst.Length <= 0) return "";
        
        var iLenght = lst[0].Length;
        var prefix = "";
        var currentPrefix = "";

        for (var i = 0; i < iLenght-1;i++)
        {
            currentPrefix = lst[0][..i];
            
            if (!lst.All(s => s.StartsWith(currentPrefix))) break;

            prefix = currentPrefix;
        }

        return prefix;
    }
}