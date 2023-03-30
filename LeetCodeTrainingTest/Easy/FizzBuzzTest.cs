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
    
    [Fact]
    private void FizzBuzz_10001_ReturnsEmpty()
    {
        var result = GetFizz(10001);
        Assert.Empty(result);
    }
    
    [Fact]
    private void FizzBuzz_1_1()
    {
        var expected = new List<string> {"1"};
        var result = GetFizz(1);
        Assert.Equal(expected, result);
    }

    [Fact]
    private void FizzBuzz_2_12()
    {
        var expected = new List<string> {"1", "2"};
        var result = GetFizz(2);
        Assert.Equal(expected, result);
    }
    
    [Fact]
    private void FizzBuzz_3_12Fizz()
    {
        var expected = new List<string> {"1","2","Fizz"};
        var result = GetFizz(3);
        Assert.Equal(expected, result);
    }
    
    [Fact]
    private void FizzBuzz_4_12Fizz4()
    {
        var expected = new List<string> {"1","2","Fizz", "4"};
        var result = GetFizz(4);
        Assert.Equal(expected, result);
    }
    
    [Fact]
    private void FizzBuzz_5_12Fizz4Buzz()
    {
        var expected = new List<string> {"1","2","Fizz","4","Buzz"};
        var result = GetFizz(5);
        Assert.Equal(expected, result);
    }
    
    [Fact]
    private void FizzBuzz_6_12Fizz4BuzzFizz()
    {
        var expected = new List<string> {"1","2","Fizz","4","Buzz", "Fizz"};
        var result = GetFizz(6);
        Assert.Equal(expected, result);
    }
    
    [Fact]
    private void FizzBuzz_15_12Fizz4BuzzFizz78FizzBuzz11Fizz1314FizzBuzz()
    {
        var expected = new List<string> {"1","2","Fizz","4","Buzz","Fizz","7","8","Fizz","Buzz","11","Fizz","13","14","FizzBuzz"};
        var result = GetFizz(15);
        Assert.Equal(expected, result);
    }
}