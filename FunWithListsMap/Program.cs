using System;
using System.Collections.Generic;

namespace FunWithListsMap
{
    internal class Node<T>
    {
        public T Data { get; }
        public Node<T> Next { get; set; }

        public Node(T data)
        {
            Data = data;
        }

        public Node(T data, Node<T> next)
        {
            Data = data;
            Next = next;
        }
    }

    internal static class Program
    {
        private static Node<T2> Map<T, T2>(Node<T> head, Func<T, T2> f) 
        {
            if (head == null)
            {
                return null;
            }

            Node<T2> result = new Node<T2>(f(head.Data));
            Node<T2> resultCurrent = result;
            
            Node<T> current = head.Next;
            
            while (current != null)
            {
                resultCurrent.Next = new Node<T2>(f(current.Data));
                resultCurrent = resultCurrent.Next;
                current = current.Next;
            }
            // return head == null ? null : new Node<T2>(f(head.data), Map(head.next, f)); 
            return result;
        }
        
        static void Main(string[] args)
        {
            Node<int> testNode = new Node<int>(1, new Node<int>(2, new Node<int>(3)));
            Node<int> newNode = Map(testNode, n => n * 3);
            
            if (newNode == null)
            {
                Console.WriteLine("null");
            }
            else
            {
                Node<int> current = newNode;
                while (current != null)
                {
                    Console.WriteLine(current.Data);
                    current = current.Next;
                }
            }
            Console.ReadKey();
        }
    }
}