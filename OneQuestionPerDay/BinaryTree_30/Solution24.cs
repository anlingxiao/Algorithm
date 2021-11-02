namespace BinaryTree_30
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Solution24
    {
        /// <summary>
        /// 110. 平衡二叉树.
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public bool IsBalanced(TreeNode root)
        {
            return Deep(root) >= 0;
        }

        private int Deep(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            int left = Deep(root.left);
            int right = Deep(root.right);
            if (left == -1 || right == -1 || Math.Abs(left - right) > 1)
            {
                return -1;
            }
            return Math.Max(Deep(root.left), Deep(root.right)) + 1;
        }
    }
}
