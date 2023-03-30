namespace LeetCodeTraining.Hard;

public class NumberOfDigitOne
{
    public int CountDigitOne(int n)
    {
        if (n is <= 0 or > 1000000000) return 0;
        
        var count = 0;
        for (var i = 0; i <= n; i++)
        {
            var iString = i.ToString();
            count += iString.Count(c => c.Equals('1'));
        }

        return count;
    }
}