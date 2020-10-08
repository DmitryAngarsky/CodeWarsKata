using System;

namespace SumTheTree
{
    public class Node
    {
        public int Value;
        public Node Left;
        public Node Right;

        public Node(int value, Node left = null, Node right = null)
        {
            Value = value;
            Left = left;
            Right = right;
        }

        public static int SumTree(Node root)
        {
            return root == null ? 0 : root.Value + SumTree(root.Left) + SumTree(root.Right);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Node test = new Node(10, new Node(1), new Node(2));

            Console.WriteLine(Node.SumTree(test));
            Console.ReadKey();
        }
    }
}