using LeetCodeTraining.Medium;

namespace LeetCodeTrainingTest.Medium;

public class AddTwoNumbersTest
{
    private AddTwoNumbersSolution _solution = new();

    private ListNode GetListNode(ListNode l1, ListNode l2) =>
        _solution.AddTwoNumbers(l1, l2);
}