using Patterns.SOLID.DependencyInversionPrinciple.DIPInterfaces;
using System;

namespace Patterns.SOLID.DependencyInversionPrinciple
{
    public class Logger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"Write to console: { message }");
        }
    }
}
