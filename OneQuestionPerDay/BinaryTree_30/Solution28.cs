namespace BinaryTree_30
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Solution28
    {
        /// <summary>
        /// 114. 二叉树展开为链表.
        /// </summary>
        /// <param name="root"></param>
        public void Flatten(TreeNode root)
        {
            DLR(root);
            for (int i = 0; i < list.Count - 1; i++)
            {
                list[i].left = null;
                list[i].right = list[i + 1];
            }
        }
        IList<TreeNode> list = new List<TreeNode>();
        private void DLR(TreeNode root)
        {
            if (root == null)
            {
                return;
            }
            list.Add(root);
            DLR(root.left);
            DLR(root.right);
        }
    }
}
