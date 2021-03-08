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
            // The key change is that instead of having a list of PersonModel we have a list of IApplicantModel
            // This means that we can put any type of model in here, any type of class that implements the IApplicantModel
            List<IApplicantModel> applicants = new List<IApplicantModel>()
            {
                new PersonModel {FirstName = "Tim", LastName="Corey" },
                new ManagerModel {FirstName = "Sue", LastName="Storm" },
                new ExecutiveModel {FirstName = "Nancy", LastName="Roman" }
            };

            List<EmployeeModel> employees  = new List<EmployeeModel>();

            foreach(var person in applicants)
            {
                employees.Add(person.AccountProcessor.Create(person));
            }

            foreach (var emp in employees)
            {
                Console.WriteLine($"{emp.FirstName} {emp.LastName}: {emp.EmailAddress} IsManager: {emp.IsManager} IsExecutive: {emp.IsExecutive}");
            }

            Console.ReadLine();
        }
    }
}
