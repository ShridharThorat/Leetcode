namespace Medium;

public class _003_
{
    public static int LengthOfLongestSubstring(string s)
    {
        Queue<char> currentSubString = new Queue<char>();
        int i = 0;
        int max = 0;
        while (i < s.Length)
        {
            if (currentSubString.Contains(s[i]) == false)
            {
                currentSubString.Enqueue(s[i]);
                i++;
            }
            else
            {
                max = Math.Max(max, currentSubString.Count);
                // Remove the first char, i.e. the one we found a duplicate for
                currentSubString.Dequeue();
            }


        }
        max = Math.Max(max, currentSubString.Count);
        return max;
    }
    // public static void Main()
    // {
    //     // Sample Linked Lists
    //     ListNode l1 = new ListNode(2, new ListNode(4, new ListNode(3)));
    //     ListNode l2 = new ListNode(5, new ListNode(6, new ListNode(4)));

    //     ListNode l3 = new ListNode(9, new ListNode(9, new ListNode(9)));
    //     ListNode l4 = new ListNode(1);
    //     ListNode? result1 = _002_.AddTwoNumbers(l1, l4);

    //     while (result1 != null)
    //     {
    //         Console.Write($"{result1.val} ");
    //         result1 = result1.next;
    //     }

    // }
}
