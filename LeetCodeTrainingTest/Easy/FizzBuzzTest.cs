using LeetCodeTraining.Easy;

namespace LeetCodeTrainingTest.Easy;

public class FizzBuzzTest
{
    private FizzBuzzSolution _solution = new();
    private IEnumerable<string> GetFizz(int n) => _solution.FizzBuzz(n);
    
    [Fact]
    private void FizzBuzz_0_ReturnsEmpty()
    {
        var result = GetFizz(0);
        Assert.Empty(result);
    }
}