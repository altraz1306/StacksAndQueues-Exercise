using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.BasicStackOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] operations = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var stack = new Stack<int>();

            var cmdPush = operations[0];
            var cmdPop = operations[1];
            var checkOperation = operations[2];

            for (int i = 0; i < cmdPush; i++)
            {
                stack.Push(numbers[i]);
            }
            for (int i = 0; i < cmdPop; i++)
            {
                stack.Pop();
            }
            if (stack.Contains(checkOperation))
            {
                Console.WriteLine("true");
            }
            else
            {
                if (stack.Any())
                {
                    Console.WriteLine(stack.Min());
                }
                else
                {
                    Console.WriteLine(0);
                }
            }
          
        }
    }
}
