namespace BinaryTree_30
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Solution5
    {
        /// <summary>
        /// 96.不同的二叉搜索树
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int NumTrees(int n)
        {
            //IList<TreeNode> list = new List<TreeNode>();
            //list = new Solution4().GenerateTrees(n);
            //return list.Count;
            return DLR(1, n);
        }
        private int DLR(int start, int end)
        {
            if (start > end)
            {
                return 0;
            }
            if (start == end)
            {
                return 1;
            }
            int sum = 0;
            for (int i = start; i <= end; i++)
            {
                int left = DLR(start, i - 1);
                int right = DLR(i + 1, end);
                if (left == 0) sum += right;
                else if (right == 0) sum += left;
                else
                {
                    sum += left * right;
                }
            }
            return sum;
        }
        public int NumTrees2(int n)
        {
            int[] G = new int[n + 1];
            G[0] = 1;
            G[1] = 1;
            for (int i = 2; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    G[i] += G[j - 1] * G[i - j];
                }
            }
            return G[n];
        }
    }
}
