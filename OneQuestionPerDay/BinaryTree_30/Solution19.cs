namespace BinaryTree_30
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Solution19
    {
        /// <summary>
        /// 236. 二叉树的最近公共祖先.
        /// </summary>
        /// <param name="root"></param>
        /// <param name="p"></param>
        /// <param name="q"></param>
        /// <returns></returns>
        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            if (root == p || root == q)
            {
                return root;
            }
            if (InTree(root.left, p) && InTree(root.left, q))
            {
                return LowestCommonAncestor(root.left, p, q);
            }
            else if (InTree(root.right, p) && InTree(root.right, q))
            {
                return LowestCommonAncestor(root.right, p, q);
            }
            else
            {
                return root;
            }
        }
        private bool InTree(TreeNode root, TreeNode node)
        {
            if (root == node)
            {
                return true;
            }
            if (root == null)
            {
                return false;
            }
            return InTree(root.left, node) || InTree(root.right, node);
        }
    }
}
