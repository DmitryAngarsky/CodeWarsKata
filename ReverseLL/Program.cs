using System;
using System.Collections.Generic;

namespace ReverseLL
{
    public class Node : Object
    {
        private int _data;
        private Node _next;

        public Node(int data, Node next = null)
        {
            this._data = data;
            this._next = next;
        }

        public override bool Equals(Object obj)
        {
            // Check for null values and compare run-time types.
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            return this.ToString() == obj.ToString();
        }

        public override string ToString()
        {
            List<int> result = new List<int>();
            Node curr = this;

            while (curr != null)
            {
                result.Add(curr._data);
                curr = curr._next;
            }

            return string.Join(" -> ", result) + " -> null";
        }
        
        public static Node ReverseList(Node node)
        {
            Node prev = null;

            while( node != null )
            {
                Node next = node._next;
                node._next = prev;
                prev = node;
                node = next;
            }

            return prev;
        }
    }

    internal static class Program
    {
        static void Main(string[] args)
        {
            Node testNode = new Node(3, new Node(2, new Node(1)));
            
            Console.WriteLine(Node.ReverseList(testNode));
            Console.ReadKey();
        }
    }
}