using Patterns.Common;
using System;

namespace ConsoleUI
{
    public class Application
    {
        public void Start()
        {
            Display.Start();
            Choice();
        }

        private void Choice()
        {
            Console.Write("\nMake your choice: ");
            var input = Console.ReadLine();
            Command(input);
        }

        private void Command(string command)
        {
            var implementation = new Implementation();
            Console.Clear();

            switch (command)
            {
                case "-h":
                case "--help":
                    {
                        Display.Help();
                    }
                    break;

                case "-srp":
                case "--single":
                    {
                        Console.WriteLine("Single Responsibility Principle");
                        implementation.GetSingleResponsibilityPrincipleInstance().RunAtConsole();
                    }
                    break;
                default:
                    {
                        Display.Error();
                    }
                    break;
            }

            Choice();
        }
    }
}
