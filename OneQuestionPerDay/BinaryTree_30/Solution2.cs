namespace BinaryTree_30
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Solution2
    {
        int maxPath = 0;
        /// <summary>
        /// 543.二叉树的直径
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public int DiameterOfBinaryTree(TreeNode root)
        {
            MaxChildrenPath(root);
            return maxPath;
        }
        private int MaxChildrenPath(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            int left = MaxChildrenPath(root.left);
            int right = MaxChildrenPath(root.right);
            if (root.left != null) left++;
            if (root.right != null) right++;
            int path = left + right;
            maxPath = Math.Max(maxPath, path);
            return Math.Max(left, right);
        }
    }
}
