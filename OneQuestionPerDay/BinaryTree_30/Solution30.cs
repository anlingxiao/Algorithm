namespace BinaryTree_30
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Solution30
    {
        /// <summary>
        /// 987. 二叉树的垂序遍历.
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public IList<IList<int>> VerticalTraversal(TreeNode root)
        {
            IList<IList<int>> ans = new List<IList<int>>();
            LDR(root, new Tuple<int, int>(0, 0));
            dic = dic.OrderBy(k => k.Key).ToDictionary(d => d.Key, d => d.Value);
            foreach (var item in dic)
            {
                IList<int> list = item.Value.OrderBy(i => i.node.val).OrderBy(i => i.tuple.Item1).Select(i => i.node.val).ToList();
                ans.Add(list);
            }
            return ans;
        }
        Dictionary<int, List<TupleTree>> dic = new Dictionary<int, List<TupleTree>>();
        private void LDR(TreeNode root, Tuple<int, int> tuple)
        {
            if (root == null)
            {
                return;
            }

            LDR(root.left, new Tuple<int, int>(tuple.Item1 + 1, tuple.Item2 - 1));
            if (!dic.ContainsKey(tuple.Item2))
            {
                dic.Add(tuple.Item2, new List<TupleTree>() { new TupleTree(root, tuple) });
            }
            else
            {
                dic[tuple.Item2].Add(new TupleTree(root, tuple));
            }

            LDR(root.right, new Tuple<int, int>(tuple.Item1 + 1, tuple.Item2 + 1));
        }
        class TupleTree
        {
            public Tuple<int, int> tuple;
            public TreeNode node;
            public TupleTree(TreeNode node, Tuple<int, int> tuple)
            {
                this.tuple = tuple;
                this.node = node;
            }
            public TupleTree Left
            {
                get
                {
                    TreeNode leftNode = this.node.left;
                    Tuple<int, int> leftTuple = new Tuple<int, int>(tuple.Item1 + 1, tuple.Item2 - 1);
                    return new TupleTree(leftNode, leftTuple);
                }
            }
            public TupleTree Right
            {
                get
                {
                    TreeNode rightNode = this.node.right;
                    Tuple<int, int> rightTuple = new Tuple<int, int>(tuple.Item1 + 1, tuple.Item2 + 1);
                    return new TupleTree(rightNode, rightTuple);
                }
            }
        }
    }
}
