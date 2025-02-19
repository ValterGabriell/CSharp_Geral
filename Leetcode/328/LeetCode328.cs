namespace CSharpGeral.Leetcode._328
{
    public static class LeetCode328
    {
        public static ListNode? OddEvenList(ListNode head)
        {
            if (head is null) return head;

            ListNode odd = head;
            ListNode even = head.next;

            //manter o head do par
            ListNode evenHead = head.next;

            while (even is not null && even.next is not null)
            {
                //troca os ponteiros da lista impar
                odd.next = odd.next.next;
                odd = odd.next;

                even.next = even.next.next;
                even = even.next;
            }

            odd.next = evenHead;
            return head;
        }
    }
}


/**
             ListNode head = new ListNode(1);
            head.next = new ListNode(2);
            head.next.next = new ListNode(3);
            head.next.next.next = new ListNode(4);
            head.next.next.next.next = new ListNode(5);

            LeetCode328.OddEvenList(head);
 */
