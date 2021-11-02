namespace BinaryTree_30
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Solution12
    {
        /// <summary>
        /// 226. 翻转二叉树.
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public TreeNode InvertTree(TreeNode root)
        {
            if (root == null)
            {
                return null;
            }
            else
            {
                TreeNode node = root.left;
                root.left = InvertTree(root.right);
                root.right = InvertTree(node);
            }
            return root;
        }
    }
}
