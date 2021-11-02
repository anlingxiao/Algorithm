namespace BinaryTree_30
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Solution4
    {
        /// <summary>
        /// 95.不同的二叉搜索树二
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public IList<TreeNode> GenerateTrees(int n)
        {
            return DLR(1, n);
        }
        private IList<TreeNode> DLR(int start, int end)
        {
            if (start > end)
            {
                return new List<TreeNode>();
            }
            if (start == end)
            {
                return new List<TreeNode>() { new TreeNode(start) };
            }
            IList<TreeNode> result = new List<TreeNode>();
            for (int i = start; i <= end; i++)
            {
                IList<TreeNode> leftList = DLR(start, i - 1);
                IList<TreeNode> rightList = DLR(i + 1, end);
                if (leftList.Count == 0)
                {
                    foreach (var item in rightList)
                    {
                        TreeNode root = new TreeNode(i);
                        root.right = item;
                        result.Add(root);
                    }
                }
                else if (rightList.Count == 0)
                {
                    foreach (var item in leftList)
                    {
                        TreeNode root = new TreeNode(i);
                        root.left = item;
                        result.Add(root);
                    }
                }
                else
                {
                    foreach (var left in leftList)
                    {
                        foreach (var ritht in rightList)
                        {
                            TreeNode root = new TreeNode(i);
                            root.left = left;
                            root.right = ritht;
                            result.Add(root);
                        }
                    }
                }
            }
            return result;
        }
    }
}
