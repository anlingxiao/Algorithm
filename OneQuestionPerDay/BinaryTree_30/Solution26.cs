namespace BinaryTree_30
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Solution26
    {
        /// <summary>
        /// 404. 左叶子之和.
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public int SumOfLeftLeaves(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            TreeNode left = root.left;
            TreeNode right = root.right;
            int sum = 0;
            if (left != null)
            {               
                if (left.left == null && left.right == null)
                {
                    sum += left.val;
                }
                sum += SumOfLeftLeaves(left);
            }
            if (right != null)
            {
                sum += SumOfLeftLeaves(right);
            }

            return sum;
        }
    }
}
