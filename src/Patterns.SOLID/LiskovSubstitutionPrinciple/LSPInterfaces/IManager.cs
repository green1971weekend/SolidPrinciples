namespace Patterns.SOLID.LiskovSubstitutionPrinciple
{
    public interface IManager : IEmployee
    {
        void GeneratePerformanceReview();
    }
}
