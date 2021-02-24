using System;

namespace Patterns.SOLID.SingleResponsibilityPrinciple
{
    /// <summary>
    /// This class generates the account specific message which is being one responsibility of this type. Seems to be a StandardMessages is the wrong place because of another responsibility(Displaying messages in StandardMessages can be related to different models as opposed to AccountGenerator.).
    /// </summary>
    public class AccountGenerator
    {
        public static void CreateAccount(Person user)
        {
            Console.WriteLine($"Your username is {user.FirstName.Substring(0, 1)}{user.LastName} ");
        }
    }
}
