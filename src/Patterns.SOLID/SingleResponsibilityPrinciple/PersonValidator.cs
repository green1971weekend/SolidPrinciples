using System;

namespace Patterns.SOLID.SingleResponsibilityPrinciple
{
    /// <summary>
    /// This class has only one reason to change and that's how person validation is happening.
    /// </summary>
    public class PersonValidator
    {
        public static bool Validate(Person person)
        {
            if (string.IsNullOrWhiteSpace(person.FirstName))
            {
                StandardMessages.DisplayValidationError("first name");
                return false;
            }

            if (string.IsNullOrWhiteSpace(person.LastName))
            {
                StandardMessages.DisplayValidationError("last name");
                return false;
            }

            return true;
        }
    }
}
