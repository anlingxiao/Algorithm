namespace BinaryTree_30
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Solution9
    {
        /// <summary>
        /// 106. 从中序与后序遍历序列构造二叉树.
        /// </summary>
        /// <param name="inorder"></param>
        /// <param name="postorder"></param>
        /// <returns></returns>
        public TreeNode BuildTree(int[] inorder, int[] postorder)
        {
            if (inorder.Length == 0)
            {
                return null;
            }
            if (inorder.Length == 1)
            {
                return new TreeNode(inorder[0]);
            }
            int rootVal = postorder.Last();
            int rootIndex = Array.IndexOf(inorder, rootVal);
            int[] leftInorder = new int[rootIndex];
            Array.Copy(inorder, leftInorder, rootIndex);
            int[] leftPostorder = new int[rootIndex];
            Array.Copy(postorder, leftPostorder, rootIndex);
            int[] rightInorder = new int[inorder.Length - rootIndex - 1];
            Array.Copy(inorder, rootIndex + 1, rightInorder, 0, rightInorder.Length);
            int[] rightPostorder = new int[inorder.Length - rootIndex - 1];
            Array.Copy(postorder, rootIndex, rightPostorder, 0, rightPostorder.Length);
            TreeNode root = new TreeNode(rootVal);
            root.left = BuildTree(leftInorder, leftPostorder);
            root.right = BuildTree(rightInorder, rightPostorder);
            return root;
        }
    }
}
