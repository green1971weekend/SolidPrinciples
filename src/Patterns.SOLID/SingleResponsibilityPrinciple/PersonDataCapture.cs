using System;

namespace Patterns.SOLID.SingleResponsibilityPrinciple
{
    /// <summary>
    /// The only one goal this class is executing - capturing person data. So this is the only one single reason or purpose for changing this class.
    /// </summary>
    public class PersonDataCapture
    {
        public static Person CaptureData()
        {
            Person output = new Person();

            Console.WriteLine("What is your first name: ");
            output.FirstName = Console.ReadLine();

            Console.WriteLine("What is your last name: ");
            output.LastName = Console.ReadLine();

            return output;
        }
    }
}
