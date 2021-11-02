namespace BinaryTree_30
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Solution21
    {
        /// <summary>
        /// 剑指 Offer 34. 二叉树中和为某一值的路径.
        /// </summary>
        /// <param name="root"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public IList<IList<int>> PathSum(TreeNode root, int target)
        {
            IList<IList<int>> ans = new List<IList<int>>();
            if (root == null)
            {
                return ans;
            }
            if (root.left == null && root.right == null)
            {
                if (root.val == target)
                {
                    ans.Add(new List<int>() { root.val });
                }
                return ans;
            }
            IList<IList<int>> leftList = PathSum(root.left, target - root.val);
            for (int i = 0; i < leftList.Count; i++)
            {
                leftList[i] = new List<int>() { root.val }.Concat(leftList[i]).ToList();
            }
            IList<IList<int>> rightList = PathSum(root.right, target - root.val);
            for (int i = 0; i < rightList.Count; i++)
            {
                rightList[i] = new List<int>() { root.val }.Concat(rightList[i]).ToList();
            }
            ans = leftList.Concat(rightList).ToList();
            return ans;
        }
    }
}
