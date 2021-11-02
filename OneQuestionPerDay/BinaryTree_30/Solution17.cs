namespace BinaryTree_30
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Solution17
    {
        /// <summary>
        /// 617. 合并二叉树.
        /// </summary>
        /// <param name="root1"></param>
        /// <param name="root2"></param>
        /// <returns></returns>
        public TreeNode MergeTrees(TreeNode root1, TreeNode root2)
        {
            if (root1 == null) return root2;
            if (root2 == null) return root1;
            TreeNode ans = new TreeNode(root1.val + root2.val);
            ans.left = MergeTrees(root1.left, root2.left);
            ans.right = MergeTrees(root1.right, root2.right);
            return ans;
        }
    }
}
