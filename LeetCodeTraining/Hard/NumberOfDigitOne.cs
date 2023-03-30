namespace LeetCodeTraining.Hard;

public class NumberOfDigitOne
{
    public int CountDigitOneSlow(int n)
    {
        if (n is <= 0 or > 1000000000) return 0;
        
        var count = 0;
        for (var i = 1; i <= n; i++)
        {
            var iString = i.ToString();
            count += iString.Count(c => c.Equals('1'));
        }

        return count;
    }
    
    public int CountDigitOne(int n)
    {
        if (n is <= 0 or > 1000000000) return 0;
        
        var count = 0;
        for (long i = 1; i <= n; i *= 10)
        {
            var divisor = i * 10;
            count += (int)(n / divisor * i + Math.Min(Math.Max(n % divisor - i + 1, 0), i));
        }

        return count;
    }
}