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
        if (!IsValid(l1) || !IsValid(l2)) return new ListNode();
        
        var result = new ListNode();
        var current = result;
        var carry = 0;

        while (l1 != null || l2 != null)
        {
            var sum = carry;

            if (l1 != null)
            {
                sum += l1.val;
                l1 = l1.next;
            }

            if (l2 != null)
            {
                sum += l2.val;
                l2 = l2.next;
            }

            carry = sum / 10;
            current.next = new ListNode
                
            (sum % 10);
            current = current.next;
            
            if (carry > 0 && l1 == null && l2 == null)
                current.next = new ListNode(carry);
        }
        return result.next;
    }
    
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