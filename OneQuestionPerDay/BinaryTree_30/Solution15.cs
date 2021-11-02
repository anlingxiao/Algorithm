namespace BinaryTree_30
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Solution15
    {
        /// <summary>
        /// 剑指 Offer 26. 树的子结构.
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        public bool IsSubStructure(TreeNode A, TreeNode B)
        {
            if (B == null || A == null)
            {
                return false;
            }
            return Recur(A, B) || IsSubStructure(A.left, B) || IsSubStructure(A.right, B);
        }
        private bool Recur(TreeNode A, TreeNode B)
        {
            if (B == null)
            {
                return true;
            }
            if (A == null || A.val != B.val)
            {
                return false;
            }
            return Recur(A.left, B.left) && Recur(A.right, B.right);
        }
    }
}
