namespace BinaryTree_30
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Solution23
    {
        /// <summary>
        /// 109. 有序链表转换二叉搜索树.
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public TreeNode SortedListToBST(ListNode head)
        {
            List<int> list = new List<int>();
            while (head != null)
            {
                list.Add(head.val);
                head = head.next;
            }
            return CreateTree(list);
        }
        private TreeNode CreateTree(List<int> list)
        {
            if (list.Count == 0)
            {
                return null;
            }
            int n = list.Count;
            int left = n / 2 - 1;
            int right = n / 2 + 1;
            TreeNode root = new TreeNode(list[n / 2]);
            if (n == 1)
            {
                return root;
            }
            List<int> leftList = list.GetRange(0, left + 1);
            List<int> rightList = list.GetRange(right, n - n / 2 -1);
            root.left = CreateTree(leftList);
            root.right = CreateTree(rightList);
            return root;
        }
    }
}
