using System;

namespace Patterns.SOLID.SingleResponsibilityPrinciple
{
    /// <summary>
    /// GreetingUser and EndApplication could also be in different classes following SRP. But our defenition for one single change would be a change in a messaging.
    /// </summary>
    public class StandardMessages
    {
        public static void GreetingUser()
        {
            Console.WriteLine("Welcome to the application!");
        }

        public static void DisplayValidationError(string fieldName)
        {
            Console.WriteLine($"You did not give a valid {fieldName}");
        }

        public static void EndApplication()
        {
            Console.ReadLine();
        }
    }
}
