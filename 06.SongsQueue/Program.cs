using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.SongsQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var playList = new Queue<string>(Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries));

            while (playList.Any())
            {
                string[] songList = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
                var cmds = songList[0];
                if (cmds == "Play")
                {
                    playList.Dequeue();
                }
                if (cmds == "Add")
                {
                    var song = string.Join(" ", songList.Skip(1));
                    if (playList.Contains(song))
                    {
                        Console.WriteLine($"{song} is already contained!");
                    }
                    else
                    {
                        playList.Enqueue(song);
                    }
                }
                if (cmds == "Show")
                {
                    Console.WriteLine(string.Join(", ", playList));
                } 
            }
            Console.WriteLine("No more songs!");
        }
    }
}
