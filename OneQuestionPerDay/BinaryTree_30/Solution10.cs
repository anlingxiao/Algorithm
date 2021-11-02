namespace BinaryTree_30
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Solution10
    {
        /// <summary>
        /// 107. 二叉树的层序遍历 II.
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public IList<IList<int>> LevelOrderBottom(TreeNode root)
        {
            if (root == null)
            {
                return new List<IList<int>>();
            }
            IList<IList<int>> ans = new List<IList<int>>();
            IList<IList<TreeNode>> treeList = new List<IList<TreeNode>>();
            treeList.Add(new List<TreeNode>() { root });
            while (true)
            {
                List<TreeNode> last = treeList.Last().ToList();
                List<TreeNode> temp = new List<TreeNode>();               
                for (int i = 0; i < last.Count; i++)
                {
                    if (last[i].left != null)
                        temp.Add(last[i].left);
                    if (last[i].right != null)
                        temp.Add(last[i].right);
                }
                if (last.Count == 0) break;
                else treeList.Add(temp);
            }
            treeList.RemoveAt(treeList.Count - 1);
            foreach (var list in treeList)
            {
                List<int> level = new List<int>();
                foreach (var item in list)
                {
                    level.Add(item.val);
                }
                ans.Add(level);
            }
            return ans.Reverse().ToList();
        }
    }
}
