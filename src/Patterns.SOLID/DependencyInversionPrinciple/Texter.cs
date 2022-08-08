using Patterns.SOLID.DependencyInversionPrinciple.DIPInterfaces;
using System;

namespace Patterns.SOLID.DependencyInversionPrinciple
{
    public class Texter : IMessageSender
    {
        public void SendMessage(IPerson person, string message)
        {
            Console.WriteLine($"Texting { person.FirstName } the following message: { message }");
        }
    }
}
