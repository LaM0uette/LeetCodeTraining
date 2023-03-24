using LeetCodeTraining.Medium;

namespace LeetCodeTrainingTest.Medium;

public class AddTwoNumbersTest
{
    private AddTwoNumbersSolution _solution = new();

    private ListNode GetSolution(ListNode l1, ListNode l2) =>
        _solution.AddTwoNumbers(l1, l2);
    
    private static ListNode GetListNode(IEnumerable<int> nums) =>
        nums.Aggregate((ListNode?)null, (current, num) => new ListNode(num, current));
    
    private static bool AreEqual(ListNode expected, ListNode actual)
    {
        while (expected is not null && actual is not null)
        {
            if (expected.val != actual.val)
            {
                return false;
            }
            expected = expected.next;
            actual = actual.next;
        }
        return expected == null && actual == null;
    }
    
    [Fact]
    public void AddTwoNumbers_00_0()
    {
        var l1 = GetListNode(new[] {0});
        var l2 = GetListNode(new[] {0});
        
        var expected = GetListNode(new[] {0});
        var actual = GetSolution(l1, l2);
        
        Assert.True(AreEqual(expected, actual));
    }
    
    [Fact]
    public void AddTwoNumbers_11_2()
    {
        var l1 = GetListNode(new[] {1});
        var l2 = GetListNode(new[] {1});
        
        var expected = GetListNode(new[] {2});
        var actual = GetSolution(l1, l2);
        
        Assert.True(AreEqual(expected, actual));
    }
    
    [Fact]
    public void AddTwoNumbers_0000_0()
    {
        var l1 = GetListNode(new[] {0, 0});
        var l2 = GetListNode(new[] {0, 0});
        
        var expected = GetListNode(new[] {0});
        var actual = GetSolution(l1, l2);
        
        Assert.True(AreEqual(expected, actual));
    }
    
    [Fact]
    public void AddTwoNumbers_0101_20()
    {
        var l1 = GetListNode(new[] {0, 1});
        var l2 = GetListNode(new[] {0, 1});
        
        var expected = GetListNode(new[] {2, 0});
        var actual = GetSolution(l1, l2);
        
        Assert.True(AreEqual(expected, actual));
    }
    
    [Fact]
    public void AddTwoNumbers_243564_708()
    {
        var l1 = GetListNode(new[] {2, 4, 3});
        var l2 = GetListNode(new[] {5, 6, 4});
        
        var expected = GetListNode(new[] {8, 0, 7});
        var actual = GetSolution(l1, l2);
        
        Assert.True(AreEqual(expected, actual));
    }
    
    [Fact]
    public void AddTwoNumbers_9999999_9999()
    {
        var l1 = GetListNode(new[] {9, 9, 9, 9, 9, 9, 9});
        var l2 = GetListNode(new[] {9, 9, 9, 9});
        
        var expected = GetListNode(new[] {1, 0, 0, 0, 9, 9, 9, 8});
        var actual = GetSolution(l1, l2);
        
        Assert.True(AreEqual(expected, actual));
    }
}