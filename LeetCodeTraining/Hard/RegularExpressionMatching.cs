namespace LeetCodeTraining.Hard;

public class RegularExpressionMatching
{
    public bool IsMatch(string s, string p) {
        var dp = new bool[s.Length+1, p.Length+1];
        dp[s.Length, p.Length] = true;

        for (var i = s.Length; i >= 0; i--)
        {
            for (var j = p.Length - 1; j >= 0; j--)
            {
                var firstMatch = i < s.Length && (p[j].Equals(s[i]) || p[j].Equals('.'));

                if (j+1 < p.Length && p[j+1].Equals('*')){
                    dp[i,j] = dp[i,j+2] || firstMatch && dp[i+1,j];
                } else {
                    dp[i,j] = firstMatch && dp[i+1,j+1];
                }
            }
        }
        return dp[0,0];
    }
}