using System;

namespace Patterns.SOLID.LiskovSubstitutionPrinciple
{
    /// <summary>
    /// Our inherited type should be able to put in place wherever you see an employee and not break an application.
    /// </summary>
    public class CEO : BaseEmployee, IManager
    {
        public override void CalculatePerHourRate(int rank)
        {
            decimal baseAmount = 150M;

            Salary = baseAmount + rank;
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
