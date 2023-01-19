using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.BalancedParenthesis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var bracket = Console.ReadLine();
            var stack = new Stack<char>();
            foreach (var item in bracket)
            {
                if (item == '(')
                {
                    stack.Push(item);
                }
                if (item == '[')
                {
                    stack.Push(item);
                }
                if (item == '{')
                {
                    stack.Push(item);
                }
                if (item == ')')
                {
                    if (stack.Count == 0 || stack.Pop() != '(')
                    {
                        Console.WriteLine("NO");
                        return;
                    }
                }
                if (item == ']')
                {
                    if (stack.Count == 0 || stack.Pop() != '[')
                    {
                        Console.WriteLine("NO");
                        return;
                    }
                }
                if (item == '}')
                {
                    if (stack.Count == 0 || stack.Pop() != '{')
                    {
                        Console.WriteLine("NO");
                        return;
                    }
                }
            }
            if (stack.Count > 0)
            {
                Console.WriteLine("NO");
            }
            else
            {
                Console.WriteLine("YES");
            }
        }
    }
}
