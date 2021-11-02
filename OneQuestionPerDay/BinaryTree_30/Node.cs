namespace BinaryTree_30
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Node
    {
        public int val;
        public Node left;
        public Node right;

        public Node() { }

        public Node(int _val)
        {
            val = _val;
            left = null;
            right = null;
        }

        public Node(int _val, Node _left, Node _right)
        {
            val = _val;
            left = _left;
            right = _right;
        }
    }
}
