namespace Patterns.SOLID.OpenClosedPrinciple
{
    /// <summary>
    /// OCP states that we shoudn't be changing functionality once it's in production. While it's in development we can modify some functionality.
    /// For the ordinary accounts we have ordinary account implementation.
    /// </summary>
    public class Accounts : IAccounts
    {
        public EmployeeModel Create(IApplicantModel person)
        {
            EmployeeModel output = new EmployeeModel();

            output.FirstName = person.FirstName;
            output.LastName = person.LastName;
            output.EmailAddress = $"{person.FirstName.Substring(0, 1)}{person.LastName}@mail.com";

            return output;
        }
    }
}
