using System;
using System.Collections.Generic;
using System.Linq;

namespace TtreesMaxSum
{
    class TreeNode
    {
        public TreeNode left;
        public TreeNode right;
        public int value;

        public TreeNode(int value)
        {
            this.value = value;
        }

        public TreeNode(int value, TreeNode left, TreeNode right)
        {
            this.value = value;
            this.left = left;
            this.right = right;
        }

        public void Leaf(int value)
        {
            this.value = value;
        }

        public void Join(TreeNode left, TreeNode right)
        {
            this.left = left;
            this.right = right;
        }
    }

    class Program
    {
        public static int MaxSum(TreeNode root)
        {
            List<int> sumCollection = new List<int>();

            void Detour(TreeNode Root, int sum)
            {
                if(Root != null)
                {
                    Detour(Root.left, sum + Root.left.value);
                    sumCollection.Add(sum);

                    Detour(Root.right, sum + Root.left.value);
                    sumCollection.Add(sum);
                }
            }
            Detour(root, 0);
            return sumCollection.Count <= 0 ? 0 : sumCollection.Max(); // TODO: implementation
        }

        static void Main(string[] args)
        {
            TreeNode left = new TreeNode(-22);
            left.Join(new TreeNode(9), new TreeNode(50));

            TreeNode right = new TreeNode(11);
            right.Join(new TreeNode(9), new TreeNode(2));

            TreeNode root = new TreeNode(5, left, right);

            Console.WriteLine(MaxSum(root));
            Console.ReadKey();
        }
    }
}
