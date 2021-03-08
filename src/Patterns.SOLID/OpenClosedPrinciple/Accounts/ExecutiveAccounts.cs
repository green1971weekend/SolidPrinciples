using System;

namespace Patterns.SOLID.OpenClosedPrinciple
{
    /// <summary>
    /// For the executive accounts we have executive account implementation.
    /// </summary>
    public class ExecutiveAccounts : IAccounts
    {
        public EmployeeModel Create(IApplicantModel person)
        {
            EmployeeModel output = new EmployeeModel();

            output.FirstName = person.FirstName;
            output.LastName = person.LastName;
            output.EmailAddress = $"{person.FirstName}.{person.LastName}@CEOmail.com";

            output.IsManager = true;
            output.IsExecutive = true;

            return output;
        }
    }
}
