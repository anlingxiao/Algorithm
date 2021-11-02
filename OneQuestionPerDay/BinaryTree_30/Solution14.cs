namespace BinaryTree_30
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// 剑指 Offer 37. 序列化二叉树.
    /// </summary>
    class Solution14
    {
        // Encodes a tree to a single string.
        public string serialize(TreeNode root)
        {
            return rserialize(root, "");
        }
        private string rserialize(TreeNode root, string str)
        {
            if (root == null)
            {
                str += "null,";
            }
            else
            {
                str += root.val.ToString() + ",";
                str = rserialize(root.left, str);
                str = rserialize(root.right, str);
            }
            return str;
        }

        // Decodes your encoded data to tree.
        public TreeNode deserialize(string data)
        {
            data = data.Replace("[", "").Replace("]", "");
            string[] nodes = data.Split(',');
            LinkedList<string> list = new LinkedList<string>(nodes.ToList());
            return rdeserialize(list);
        }
        private TreeNode rdeserialize(LinkedList<string> list)
        {
            if (list.Count == 0)
            {
                return null;
            }
            if (list.First.Value.Equals("null"))
            {
                list.RemoveFirst();
                return null;
            }
            TreeNode root = new TreeNode(int.Parse(list.First.Value));
            list.RemoveFirst();
            root.left = rdeserialize(list);
            root.right = rdeserialize(list);
            return root;
        }
    }
}
