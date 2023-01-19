using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MaximumAndMinimumElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var countOfNumber = int.Parse(Console.ReadLine());
            var stack = new Stack<int>();


            for (int i = 0; i < countOfNumber; i++)
            {
                int[] elements = Console.ReadLine()
               .Split(" ", StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToArray();
                if (elements[0] == 1)
                {
                    stack.Push(elements[1]);
                }
                if (elements[0] == 2 && stack.Any())
                {
                    stack.Pop();
                }
                if (elements[0] == 3 && stack.Any())
                {
                    Console.WriteLine(stack.Max());
                }
                if (elements[0] == 4 && stack.Any())
                {
                    Console.WriteLine(stack.Min());
                }
            }
            Console.WriteLine(string.Join(", ", stack));

        }
    }
}
