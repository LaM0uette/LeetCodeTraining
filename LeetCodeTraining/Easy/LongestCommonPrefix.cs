﻿namespace LeetCodeTraining.Easy;

public class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {
        if (strs.Length.Equals(0)) return "";

        for (var i = 0; i < strs[0].Length; i++)
        {
            var c = strs[0][i];
            for (var j = 1; j < strs.Length; j++)
            {
                if (i.Equals(strs[j].Length) || !strs[j][i].Equals(c))
                    return strs[0][..i];
            }
        }

        return strs[0];
    }
}