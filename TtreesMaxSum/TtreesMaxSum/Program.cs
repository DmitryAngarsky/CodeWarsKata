﻿using System;
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
            /* case 1 */
            if (root.left == null && root.right == null)
                return root.value;

            /* case 2 */
            if (root.right == null)
                return root.value + MaxSum(root.left);
            else if (root.left == null)
                return root.value + MaxSum(root.right);

            /* case 3 */
            return Math.Max(root.value + MaxSum(root.left), root.value + MaxSum(root.right));
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
