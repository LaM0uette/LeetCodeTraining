namespace LeetCodeTraining.Medium;

public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int val=0, ListNode next=null!) {
           this.val = val;
           this.next = next;
       }
}

public class AddTwoNumbersSolution
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        if (!IsValid(l1)) return new ListNode();
        if (!IsValid(l2)) return new ListNode();
        
        var calculatedNumber = GetNumber(l1) + GetNumber(l2);
        return GetListNode(calculatedNumber
            .ToString()
            .Select(x => int.Parse(x.ToString())));
    }
    
    private static int GetNumber(ListNode listNode)
    {
        var number = "";
        while (listNode is not null)
        {
            number += listNode.val;
            listNode = listNode.next;
        }
        return int.Parse(number);
    }
    
    private static ListNode GetListNode(IEnumerable<int> nums) => nums.Aggregate((ListNode?)null, (current, num) => new ListNode(num, current));
    
    private static bool IsValid(ListNode listNode) => ValidateLength(listNode) && ValidateNodeValues(listNode);
    private static bool ValidateLength(ListNode listNode)
    {
        var length = 0;
        while (listNode is not null)
        {
            length++;
            listNode = listNode.next;
        }
        return length is >= 1 and <= 100;
    }
    private static bool ValidateNodeValues(ListNode listNode)
    {
        while (listNode != null)
        {
            if (listNode.val is < 0 or > 9) return false;
            listNode = listNode.next;
        }
        return true;
    }
}