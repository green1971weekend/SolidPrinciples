using Patterns.Core.Interfaces;
using Patterns.SOLID.DependencyInversionPrinciple.DIPInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.SOLID.DependencyInversionPrinciple
{
    /// <summary>
    /// Dependency inversion principle states that high-level modules should not depend on low-level modules but rather
    /// both should depend on abstractions and those abstractions should not depend on details.
    /// </summary>
    public class DependencyInversionPrinciple : IExample
    {
        // In our case the high-level modules will be DependencyInversionPrinciple and Chore. 
        // Therefore the low-level modules will be emailer, person and logger.
        public void Start()
        {
            IPerson owner = Factory.CreatePerson();

            owner.FirstName = "Nick";
            owner.LastName = "Brown";
            owner.EmailAddress = "nick@brown.com";
            owner.PhoneNumber = "555-1212";

            IChore chore = Factory.CreateChore();

            chore.ChoreName = "Take out the trash";
            chore.Owner = owner;

            chore.PerformedWork(3);
            chore.PerformedWork(1.5);
            chore.CompleteChore();

            Console.ReadLine();
        }
    }
}
