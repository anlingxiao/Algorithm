namespace BinaryTree_30
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Solution13
    {
        /// <summary>
        /// 剑指 Offer 07. 重建二叉树
        /// </summary>
        /// <param name="preorder"></param>
        /// <param name="inorder"></param>
        /// <returns></returns>
        public TreeNode BuildTree(int[] preorder, int[] inorder)
        {
            if (preorder.Length == 0)
            {
                return null;
            }
            int rootVal = preorder[0];
            TreeNode root = new TreeNode(rootVal);
            int inorderIndex = Array.IndexOf(inorder, rootVal);
            int[] leftPreorder = new int[inorderIndex];
            Array.Copy(preorder, 1, leftPreorder, 0, inorderIndex);
            int[] leftInorder = new int[inorderIndex];
            Array.Copy(inorder, 0, leftInorder, 0, inorderIndex);
            int[] rigthtPreorder = new int[preorder.Length - inorderIndex - 1];
            Array.Copy(preorder, inorderIndex + 1, rigthtPreorder, 0, rigthtPreorder.Length);
            int[] rightInorder = new int[rigthtPreorder.Length];
            Array.Copy(inorder, inorderIndex + 1, rightInorder, 0, rightInorder.Length);
            root.left = BuildTree(leftPreorder, leftInorder);
            root.right = BuildTree(rigthtPreorder, rightInorder);
            return root;
        }
    }
}
