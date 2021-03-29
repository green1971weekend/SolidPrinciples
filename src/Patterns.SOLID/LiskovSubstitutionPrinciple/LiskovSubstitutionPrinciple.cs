using Patterns.Core.Interfaces;
using System;

namespace Patterns.SOLID.LiskovSubstitutionPrinciple
{
    /// <summary>
    /// LSP states that if S is a subtype of T then object of type T may be replaced with object of type S without breaking the program.
    /// </summary>
    public class LiskovSubstitutionPrinciple : IExample
    {
        public void Start()
        {
            IManager accountingVP = new Manager();
            accountingVP.FirstName = "Emma";
            accountingVP.LastName = "Stone";
            accountingVP.CalculatePerHourRate(4);

            IManaged emp = new Employee();
            emp.FirstName = "Tim";
            emp.LastName = "Corey";
            emp.AssignManager(accountingVP);
            emp.CalculatePerHourRate(2);

            Console.WriteLine($"{emp.FirstName}'s salary is {emp.Salary}/hour.");
            Console.ReadLine();
        }
    }
}
