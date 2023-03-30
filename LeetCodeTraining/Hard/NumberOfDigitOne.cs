namespace LeetCodeTraining.Hard;

public class NumberOfDigitOne
{
    public int CountDigitOne(int n)
    {
        if (n <= 0) return 0;
        
        var count = 0;
        for (var i = 0; i <= n; i++)
        {
            var iString = i.ToString();
            count += iString.Count(c => c.Equals('1'));
        }

        return count;
    }
}