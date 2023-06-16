namespace LeetCodeTraining.Easy;

public class Solution
{
    public string LongestCommonPrefix(string[] lst)
    {
        if (lst.Length <= 0) return "";
        
        var iLenght = lst[0].Length;
        var prefix = "";

        for (var i = 0; i < iLenght;i++)
        {
            foreach (var str in lst)
            {
                var currentPrefix = str[..i];

                if (!currentPrefix.Equals(prefix) && !prefix.Equals("")) return "";
            
                prefix = currentPrefix;
            
                i++;
            }
        }

        return prefix;
    }
}