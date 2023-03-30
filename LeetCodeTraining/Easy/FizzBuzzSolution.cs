namespace LeetCodeTraining.Easy;

public class FizzBuzzSolution
{
    public IList<string> FizzBuzz(int n)
    {
        var result = new List<string>();
        
        if (n is <= 0 or > 10000) return result;
        
        for (var i = 1; i <= n; i++)
        {
            if ((i % 3).Equals(0) && (i % 5).Equals(0))
            {
                result.Add("FizzBuzz"); 
                continue;
            }
            
            if ((i % 3).Equals(0))
            {
                result.Add("Fizz"); 
                continue;
            }
            
            if ((i % 5).Equals(0))
            {
                result.Add("Buzz"); 
                continue;
            }

            result.Add(i.ToString());
        }

        return result;
    }
}