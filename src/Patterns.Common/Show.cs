using Patterns.Core.Interfaces;
using System;

namespace Patterns.Common
{
    public static class Show
    {
        public static void RunAtConsole(this IExample example)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            example.Start();

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n\n\nPress any key to continue..");
            Console.ReadKey();
            Console.Clear();

            Display.Menu();
        }

        public static void RunAtCLI(this IExample example)
        {
            example.Start();
        }
    }
}
