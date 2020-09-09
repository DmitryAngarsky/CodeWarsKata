using System;

namespace Brackets
{
    class Stack
    {
        int maxSize;
        char[] stackArr;
        int top;

        public Stack(int s)
        {
            maxSize = s;
            stackArr = new char[maxSize];
            top = -1;
        }

        public void Push(char j) => stackArr[++top] = j;
        public char Pop() => stackArr[top--];
        public char Peek() => stackArr[top];
        public bool isEmpty() => top == -1;
    }

    class BracketCheker
    {
        private string input;

        public BracketCheker(string str) => input = str;

        public void chek()
        {
            Stack stack = new Stack(input.Length);

            for(int j = 0; j < input.Length; j++)
            {
                char ch = input[j];
                switch (ch)
                {
                    case '{':
                    case '[':
                    case '(':
                        stack.Push(ch);
                        break;
                    case '}':
                    case ']':
                    case ')':
                        if (!stack.isEmpty())
                        {
                            char chx = stack.Pop();
                            if (ch == '}' && chx != '{' ||
                                ch == ']' && chx != '[' ||
                                ch == ')' && chx != '(')
                                Console.WriteLine($"Error: {ch} at {j}");
                        }
                        else
                            Console.WriteLine($"Error: {ch} at {j}");
                        break;
                    default:
                        break;
                }
            }

            if (!stack.isEmpty())
                Console.WriteLine("Error: missing right delimiter");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string test = "a{b(c]d}e";

            BracketCheker bracket = new BracketCheker(test);
            bracket.chek();
            Console.ReadKey();
        }
    }
}
