using System;

namespace Patterns.SOLID.LiskovSubstitutionPrinciple
{
    public class CEO : Employee
    {
        public override void CalculatePerHourRate(int rank)
        {
            decimal baseAmount = 150M;

            Salary = baseAmount + rank;
        }

        public void AssignManager(Employee manager)
        {

        }

        public void GeneratePerformanceReview()
        {
            // Simulate reviewing a direct report.
            Console.WriteLine("I'm reviewing a direct report's performance.");
        }

        public void FireSomeone()
        {
            // Simulate firing someone.
            Console.WriteLine("Fired.");
        }
    }
}
