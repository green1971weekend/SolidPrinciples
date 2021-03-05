using Patterns.Core.Interfaces;
using System;
using System.Collections.Generic;

namespace Patterns.SOLID.OpenClosedPrinciple
{
    /// <summary>
    /// The principle states that objects should be open to extension and closed to modification.
    /// </summary>
    public class OpenClosedPrinciple : IExample
    {
        public void Start()
        {
            List<PersonModel> applicants = new List<PersonModel>()
            {
                new PersonModel {FirstName = "Tim", LastName="Corey" },
                new PersonModel {FirstName = "Sue", LastName="Storm" },
                new PersonModel {FirstName = "Nancy", LastName="Roman" }
            };

            List<EmployeeModel> employees  = new List<EmployeeModel>();

            Accounts accountProcessor = new Accounts();

            foreach(var person in applicants)
            {
                employees.Add(accountProcessor.Create(person));
            }

            foreach (var emp in employees)
            {
                Console.WriteLine($"{emp.FirstName} {emp.LastName}: {emp.EmailAddress}");
            }

            Console.ReadLine();
        }
    }
}
