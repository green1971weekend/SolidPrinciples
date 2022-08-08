using Patterns.SOLID.DependencyInversionPrinciple.DIPInterfaces;
using System;

namespace Patterns.SOLID.DependencyInversionPrinciple
{
    public class Emailer : IMessageSender
    {
        public void SendMessage(IPerson person, string message)
        {
            Console.WriteLine($"Simulating sending an email to { person.EmailAddress }");
        }
    }
}
