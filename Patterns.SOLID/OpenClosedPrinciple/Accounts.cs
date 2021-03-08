using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.SOLID.OpenClosedPrinciple
{
    /// <summary>
    /// OCP states that we shoudn't be changing functionality once it's in production. While it's in development we can modify some functionality.
    /// </summary>
    public class Accounts
    {
        public EmployeeModel Create(PersonModel person)
        {
            EmployeeModel output = new EmployeeModel();

            output.FirstName = person.FirstName;
            output.LastName = person.LastName;
            output.EmailAddress = $"{person.FirstName.Substring(0, 1)}{person.LastName}@mail.com";

            //if(person.TypeOfEmployee == EmployeeType.Manager)
            //{
            //    output.IsManager = true;
            //}

            switch(person.TypeOfEmployee)
            {
                case EmployeeType.Staff:
                    break;
                case EmployeeType.Manager:
                    output.IsManager = true;
                    break;
                case EmployeeType.Executive:
                    output.IsManager = true;
                    output.IsExecutive = true;
                    break;
                default:
                    break;
            }

            return output;
        }
    }
}
