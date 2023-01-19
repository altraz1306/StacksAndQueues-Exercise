using System;
using System.Collections.Generic;

namespace _09.SimpleTextEditor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var countOfOperation = int.Parse(Console.ReadLine());
            var stack = new Stack<string>();
            var letters = string.Empty;

            for (int i = 0; i < countOfOperation; i++)
            {
                string[] order = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                var cmds = order[0];

                if (cmds == "1")
                {
                    stack.Push(letters);
                    letters += order[1];
                }

                if (cmds == "2")
                {
                    stack.Push(letters);
                    var count = int.Parse(order[1]);
                    letters = letters.Remove(letters.Length - count);
                }

                if (cmds == "3")
                {
                    var index = int.Parse(order[1]) - 1;
                    Console.WriteLine(letters[index]);
                }

                if (cmds == "4")
                {
                    letters = stack.Pop();
                }
            }
        }
    }
}
