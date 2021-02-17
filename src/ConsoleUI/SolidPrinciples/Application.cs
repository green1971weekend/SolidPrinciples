using Patterns.Common;

namespace ConsoleUI
{
    public class Application
    {
        public void Start(string[] args)
        {
            var implementation = new Implementation();

            switch (args[0])
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
                        implementation.GetSingleResponsibilityPrincipleInstance().RunAtConsole();
                    }
                    break;
            }
        }
    }
}
