namespace BinaryTree_30
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Solution22
    {
        /// <summary>
        /// 剑指 Offer 36. 二叉搜索树与双向链表.
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public Node TreeToDoublyList(Node root)
        {
            LDR(root);
            int n = nodes.Count;
            if (n == 0)
            {
                return null;
            }
            if (n == 1)
            {
                nodes[0].left = nodes[0];
                nodes[0].right = nodes[0];
                return nodes[0];
            }
            for (int i = 1; i < nodes.Count; i++)
            {
                nodes[i].left = nodes[i - 1];
                nodes[i - 1].right = nodes[i];
            }
            nodes[0].left = nodes[n - 1];
            nodes[n - 1].right = nodes[0];
            return nodes[0];
        }
        List<Node> nodes = new List<Node>();
        /// <summary>
        /// 中序遍历.
        /// </summary>
        /// <returns></returns>
        private void LDR(Node node)
        {
            if (node == null)
            {
                return;
            }
            LDR(node.left);
            nodes.Add(node);
            LDR(node.right);
        }
    }
}
