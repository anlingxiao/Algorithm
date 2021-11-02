﻿namespace BinaryTree_30
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// 297.二叉树的序列化与反序列化.
    /// </summary>
    class Solution6
    {
        // Encodes a tree to a single string.
        public string serialize(TreeNode root)
        {
            return rserialize(root, "");
        }

        public TreeNode deserialize(string data)
        {
            string[] dataArray = data.Split(",");
            LinkedList<string> dataList = new LinkedList<string>(dataArray.ToList());
            return rdeserialize(dataList);
        }

        public string rserialize(TreeNode root, string str)
        {
            if (root == null)
            {
                str += "None,";
            }
            else
            {
                str += root.val.ToString() + ",";
                str = rserialize(root.left, str);
                str = rserialize(root.right, str);
            }
            return str;
        }

        public TreeNode rdeserialize(LinkedList<string> dataList)
        {
            if (dataList.First.Value.Equals("None"))
            {
                dataList.RemoveFirst();
                return null;
            }

            TreeNode root = new TreeNode(int.Parse(dataList.First.Value));
            dataList.RemoveFirst();
            root.left = rdeserialize(dataList);
            root.right = rdeserialize(dataList);

            return root;
        }
    }
}
