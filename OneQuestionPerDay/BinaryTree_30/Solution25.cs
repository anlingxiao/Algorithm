namespace BinaryTree_30
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Solution25
    {
        /// <summary>
        /// 113. 路径总和 II.
        /// </summary>
        /// <param name="root"></param>
        /// <param name="targetSum"></param>
        /// <returns></returns>
        public IList<IList<int>> PathSum(TreeNode root, int targetSum)
        {
            if (root == null)
            {
                return new List<IList<int>>();
            }
            if (root.left == null && root.right == null && root.val == targetSum)
            {
                return new List<IList<int>>() { new List<int>() { root.val } };
            }
            IList<IList<int>> leftList = PathSum(root.left, targetSum - root.val);
            for (int i = 0; i < leftList.Count; i++)
            {
                leftList[i] = new List<int>() { root.val }.Concat(leftList[i]).ToList();
            }
            IList<IList<int>> rightList = PathSum(root.right, targetSum - root.val);
            for (int i = 0; i < rightList.Count; i++)
            {
                rightList[i] = new List<int>() { root.val }.Concat(rightList[i]).ToList();
            }
            return leftList.Concat(rightList).ToList();
        }
    }
}
