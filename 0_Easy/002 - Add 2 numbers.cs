using System.ComponentModel;
using System.Xml.XPath;

namespace Easy;


//Definition for singly-linked list.
public class ListNode
{
    public int val;
    public ListNode? next;
    public ListNode(int val = 0, ListNode? next = null)
    {
        this.val = val;
        this.next = next;
    }
}

public class _002___Add_2_numbers
{
    public ListNode? AddTwoNumbers(ListNode? l1, ListNode? l2)
    {
        ListNode? result = new ListNode();
        ListNode? current = result;
        int carry = 0; int sum = 0;
        while (l1 != null || l2 != null || carry == 1)
        {
            int v1 = (l1 != null) ? l1.val : 0;
            int v2 = (l2 != null) ? l2.val : 0;
            sum = v1 + v2 + carry;
            carry = sum > 9 ? 1 : 0;
            sum %= 10;
            current.next = new ListNode(sum);
            current = current.next;

            l1 = l1?.next;
            l2 = l2?.next;
        }
        return result.next;
    }
}
