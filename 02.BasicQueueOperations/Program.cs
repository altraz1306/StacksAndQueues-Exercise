using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.BasicQueueOperations
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
            var queue = new Queue<int>();
            var cmdsToEnqueue = operations[0];
            var cmdsToDequeue = operations[1];
            var cmdsToCheck = operations[2];

            for (int i = 0; i < cmdsToEnqueue; i++)
            {
                queue.Enqueue(numbers[i]);
            }
            for (int i = 0; i < cmdsToDequeue; i++)
            {
                queue.Dequeue();
            }
            if (queue.Contains(cmdsToCheck))
            {
                Console.WriteLine("true");
            }
            else
            {
                if (queue.Any())
                {
                    Console.WriteLine(queue.Min());
                }
                else
                {
                    Console.WriteLine(0);
                }
            }
        }
    }
}
