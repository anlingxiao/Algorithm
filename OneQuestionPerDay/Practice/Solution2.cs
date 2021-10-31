namespace Practice
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Solution2
    {
        /// <summary>
        /// 2.两数之和.
        /// </summary>
        /// <param name="l1"></param>
        /// <param name="l2"></param>
        /// <returns></returns>
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            if (l1 == null)
            {
                return l2;
            }
            if (l2 == null)
            {
                return l1;
            }
            ListNode node = new ListNode();
            node.val = l1.val + l2.val;
            node.next = AddTwoNumbers(l1.next, l2.next);
            ListNode ans = new ListNode(node.val, node.next);
            if (node.next == null)
            {
                if (node.val >= 10)
                {
                    node.val -= 10;
                    node.next = new ListNode(1);
                }
                return ans;
            }
            ans.val %= 10;
            while (node != null)
            {
                if (node.val >= 10)
                {
                    node.val -= 10;
                    if (node.next == null)
                    {
                        node.next = new ListNode(1);
                    }
                    else
                    {
                        node.next.val++;
                    }
                }
                node = node.next;
            }
            return ans;
        }

        public ListNode AddTwoNumbers2(ListNode l1, ListNode l2)
        {
            ListNode head = null;
            ListNode tail = null;
            int carry = 0;
            while (l1 != null || l2 != null)
            {
                int n1 = l1 == null ? 0 : l1.val;
                int n2 = l2 == null ? 0 : l2.val;
                int sum = n1 + n2 + carry;
                if (head == null)
                {
                    head = tail = new ListNode(sum % 10);
                }
                else
                {
                    tail.next = new ListNode(sum % 10);
                    tail = tail.next;
                }
                carry = sum / 10;
                if (l1 != null)
                {
                    l1 = l1.next;
                }
                if (l2 != null)
                {
                    l2 = l2.next;
                }
                if (carry > 0)
                {
                    tail.next = new ListNode(carry);
                }
            }
            return head;
        }
    }
}
