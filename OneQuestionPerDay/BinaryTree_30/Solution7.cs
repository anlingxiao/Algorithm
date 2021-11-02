namespace BinaryTree_30
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Solution7
    {
        /// <summary>
        /// 337.打家劫舍3
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public int Rob(TreeNode root)
        {
            return Math.Max(MaxPath(root)[0],MaxPath(root)[1]);
        }
        
        //选择节点坐标0   不选择节点坐标1
        private int[] MaxPath(TreeNode root)
        {
            if (root == null)
            {
                return new int[] { 0, 0 };
            }

            int[] l = MaxPath(root.left);
            int[] r = MaxPath(root.right);
            int chooseRoot = l[1] + r[1] + root.val;
            int no = Math.Max(l[0], l[1]) + Math.Max(r[0], r[1]);
            return new int[] { chooseRoot, no };
        }
    }
}
