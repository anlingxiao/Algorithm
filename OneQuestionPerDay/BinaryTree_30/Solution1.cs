namespace BinaryTree_30
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class Solution1
    {
        /// <summary>
        /// 156.上下反转二叉树
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public TreeNode UpsideDownBinaryTree(TreeNode root)
        {
            if (root == null || root.left == null)
            {
                return root;
            }
            TreeNode left = root.left;
            TreeNode right = root.right;
            TreeNode ans = UpsideDownBinaryTree(left);
            left.right = root;
            left.left = right;
            root.left = null;
            root.right = null;
            return ans;
        }
    }
}
