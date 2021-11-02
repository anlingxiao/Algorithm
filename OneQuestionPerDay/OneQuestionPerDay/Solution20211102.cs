namespace OneQuestionPerDay
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Solution20211102
    {
        /// <summary>
        /// 237. 删除链表中的节点.
        /// </summary>
        /// <param name="node"></param>
        public void DeleteNode(ListNode node)
        {
            node.val = node.next.val;
            node.next = node.next.next;
        }
    }
}
