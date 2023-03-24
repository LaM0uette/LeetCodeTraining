using LeetCodeTraining.Medium;

namespace LeetCodeTrainingTest.Medium;

public class AddTwoNumbersTest
{
    private AddTwoNumbersSolution _solution = new();

    private ListNode GetSolution(ListNode l1, ListNode l2) =>
        _solution.AddTwoNumbers(l1, l2);
    
    private static ListNode GetListNode(IEnumerable<int> nums) =>
        nums.Aggregate((ListNode?)null, (current, num) => new ListNode(num, current));
    
    [Fact]
    public void AddTwoNumbers_00_0()
    {
        var l1 = GetListNode(new[] {0});
        var l2 = GetListNode(new[] {0});
        
        var expected = GetListNode(new[] {0});
        Assert.Equal(expected, GetSolution(l1, l2));
    }
}