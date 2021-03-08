using Patterns.Core.Interfaces;
using System;

namespace Patterns.SOLID.SingleResponsibilityPrinciple
{
    /// <summary>
    /// SRP states that class should only have one responsibility or the one reason to change.
    /// </summary>
    public class SingleResponsibilityPrinciple : IExample
    {
        public void Start()
        {
            StandardMessages.GreetingUser();

            Person user = PersonDataCapture.CaptureData();

            bool isUserValid = PersonValidator.Validate(user);

            if(!isUserValid)
            {
                StandardMessages.EndApplication();
                return;
            }

            AccountGenerator.CreateAccount(user);
            StandardMessages.EndApplication();
        }
    }
}
