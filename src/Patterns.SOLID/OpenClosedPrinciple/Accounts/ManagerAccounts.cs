﻿namespace Patterns.SOLID.OpenClosedPrinciple
{
    /// <summary>
    /// For the manager accounts we have manager account implementation.
    /// </summary>
    public class ManagerAccounts : IAccounts
    {
        public EmployeeModel Create(IApplicantModel person)
        {
            EmployeeModel output = new EmployeeModel();

            output.FirstName = person.FirstName;
            output.LastName = person.LastName;
            output.EmailAddress = $"{person.FirstName.Substring(0, 1)}{person.LastName}@mailcorp.com";

            output.IsManager = true;

            return output;
        }
    }
}
