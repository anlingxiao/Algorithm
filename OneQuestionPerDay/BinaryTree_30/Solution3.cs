namespace BinaryTree_30
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Solution3
    {
        /// <summary>
        /// 103.二叉树的锯齿形层序遍历.
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public IList<IList<int>> ZigzagLevelOrder(TreeNode root)
        {
            IList<IList<int>> ans = BLV(root);
            for (int i = 0; i < ans.Count; i++)
            {
                if (i % 2 == 1)
                {
                    ans[i] = ans[i].Reverse().ToList();
                }
            }
            return ans;
        }

        private IList<IList<int>> BLV(TreeNode root)
        {
            if (root == null)
            {
                return new List<IList<int>>();
            }

            IList<IList<int>> ans = new List<IList<int>>();
            IList<int> rootList = new List<int>() { root.val };
            ans.Add(rootList);
            IList<IList<int>> left = BLV(root.left);
            IList<IList<int>> right = BLV(root.right);
            int n = Math.Min(left.Count, right.Count);
            for (int i = 0; i < n; i++)
            {
                IList<int> arr = left[i].Concat(right[i]).ToList();
                ans.Add(arr);
            }
            if (left.Count > n)
            {
                for (int i = n; i < left.Count; i++)
                {
                    ans.Add(left[i]);
                }
            }
            if (right.Count > n)
            {
                for (int i = n; i < right.Count; i++)
                {
                    ans.Add(right[i]);
                }
            }
            return ans;
        }
    }
}
