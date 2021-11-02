namespace BinaryTree_30
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Solution29
    {
        /// <summary>
        /// 257. 二叉树的所有路径.
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public IList<string> BinaryTreePaths(TreeNode root)
        {
            IList<string> ans = new List<string>();
            if (root == null)
            {
                return ans;
            }
            
            if (root.left == null && root.right == null)
            {
                ans = new List<string>() { root.val.ToString() };
                return ans;
            }
            IList<string> left = BinaryTreePaths(root.left);
            IList<string> right = BinaryTreePaths(root.right);
            for (int i = 0; i < left.Count; i++)
            {
                left[i] = root.val.ToString() + "->" + left[i];
            }
            for (int i = 0; i < right.Count; i++)
            {
                right[i] = root.val.ToString() + "->" + right[i];
            }
            ans = left.Concat(right).ToList();
            return ans;
        }
    }
}
