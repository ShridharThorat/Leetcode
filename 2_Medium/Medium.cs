namespace Medium
{
    public class MediumProgram
    {
        public static void Main()
        {
            // Sample Linked Lists
            ListNode l1 = new ListNode(2, new ListNode(4, new ListNode(3)));
            ListNode l2 = new ListNode(5, new ListNode(6, new ListNode(4)));

            ListNode l3 = new ListNode(9, new ListNode(9, new ListNode(9)));
            ListNode l4 = new ListNode(1);
            ListNode? result1 = _002_.AddTwoNumbers(l1,l4);

            while (result1 != null)
            {
                Console.Write($"{result1.val} ");
                result1 = result1.next;
            }

        }
        public static string GetClass()
        {
            return "Medium";
        }
    }
}