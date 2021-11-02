namespace BinaryTree_30
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Solution20
    {
        /// <summary>
        /// 129. 求根节点到叶节点数字之和.
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public int SumNumbers(TreeNode root)
        {
            return DFS(root, 0);
        }
        private int DFS(TreeNode root, int sum)
        {
            if (root == null) return 0;
            int temp = sum * 10 + root.val;
            if (root.left == null && root.right == null)
            {
                return temp;
            }
            return DFS(root.left, temp) + DFS(root.right, temp);
        }
    }
}
