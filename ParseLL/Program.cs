using System;
using System.Collections.Generic;
using System.Linq;

namespace ParseLL
{
    public class Node : Object
    {
        public int Data;
        public Node Next;

        public Node(int data, Node next = null)
        {
            this.Data = data;
            this.Next = next;
        }

        public override bool Equals(Object obj)
        {
            // Check for null values and compare run-time types.
            if (obj == null || GetType() != obj.GetType()) { return false; }

            return this.ToString() == obj.ToString();
        }

        public override string ToString()
        {
            List<int> result = new List<int>();
            Node curr = this;

            while (curr != null)
            {
                result.Add(curr.Data);
                curr = curr.Next;
            }

            return string.Join(" -> ", result) + " -> null";
        }
        
        public static Node Parse(string nodes)
        {
            return 
                nodes
                    .Split(" -> ")
                    .Reverse()
                    .Skip(1)
                    .Select(int.Parse)
                    .Aggregate((Node)null, (acc, e) => new Node(e, acc));

        }
        // My solution
        // public static Node Parse(string nodes)
        // {
        //     int[] test = nodes.Split(" -> ").Where(n => int.TryParse(n, out int _)).Select(int.Parse).ToArray();
        //     
        //     if (!test.Any())
        //     {
        //         return null;
        //     }
        //     
        //     Node result = new Node(test.First());
        //     Node curr = result;
        //
        //     for(int i = 1; i < test.Length; i++)
        //     {
        //         curr.Next = new Node(test[i]);
        //         curr = curr.Next;
        //     }
        //
        //     return result;
        // }
    }

    internal static class Program
    {
        static void Main()
        {
            const string test = "1 -> 2 -> 3 -> null";
            
            Console.WriteLine(Node.Parse(test));
            Console.ReadKey();
        }
    }
}