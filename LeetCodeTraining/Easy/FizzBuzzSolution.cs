namespace LeetCodeTraining.Easy;

public class FizzBuzzSolution
{
    public IList<string> FizzBuzz(int n)
    {
        var result = new List<string>();
        if (n is <= 0 or > 10000) return result;
        
        for (var i = 1; i <= n; i++)
        {
            var fizzBuzz = "";
            if ((i % 3).Equals(0)) fizzBuzz += "Fizz";
            if ((i % 5).Equals(0)) fizzBuzz += "Buzz";
            result.Add(fizzBuzz.Equals("") ? i.ToString() : fizzBuzz);
        }
        return result;
    }
}