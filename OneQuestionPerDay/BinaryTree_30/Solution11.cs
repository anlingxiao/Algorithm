namespace BinaryTree_30
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Solution11
    {
        /// <summary>
        /// 199. 二叉树的右视图.
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public IList<int> RightSideView(TreeNode root)
        {
            if (root == null)
            {
                return new List<int>();
            }
            IList<int> result = new List<int>();
            IList<IList<TreeNode>> queue = new List<IList<TreeNode>>();
            queue.Add(new List<TreeNode>() { root });
            while (true)
            {
                IList<TreeNode> last = queue.Last();
                IList<TreeNode> temp = new List<TreeNode>();
                for (int i = 0; i < last.Count; i++)
                {
                    if (last[i].left != null)
                        temp.Add(last[i].left);
                    if (last[i].right != null)
                        temp.Add(last[i].right);
                }
                if (temp.Count != 0) queue.Add(temp);
                else break;
            }
            for (int i = 0; i < queue.Count; i++)
            {
                result.Add(queue[i].Last().val);
            }
            return result;
        }
    }
}
