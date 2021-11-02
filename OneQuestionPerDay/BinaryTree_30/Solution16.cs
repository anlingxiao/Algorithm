namespace BinaryTree_30
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Solution16
    {
        /// <summary>
        /// 145. 二叉树的后序遍历.
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public IList<int> PostorderTraversal(TreeNode root)
        {
            IList<int> ans = new List<int>();
            Stack<TreeNode> stack = new Stack<TreeNode>();
            TreeNode node = root;
            TreeNode pre = null;
            while (node != null || stack.Count != 0)
            {
                while (node != null)
                {
                    stack.Push(node);
                    node = node.left;
                }
                node = stack.Pop();
                if (node.right == null || pre == node.right)
                {
                    ans.Add(node.val);
                    pre = node;
                    node = null;
                }
                else
                {
                    stack.Push(node);
                    node = node.right;
                }
            }
            return ans;
        }
    }
}
