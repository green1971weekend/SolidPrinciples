namespace Patterns.SOLID.OpenClosedPrinciple
{
    /// <summary>
    /// Instead of making constant changes to Accounts class we working off interfaces which allows us to change out actual implementation.
    /// Each of this implementations does something different in the create method and yet all can be called by saying IAccounts.Create
    /// </summary>
    public interface IAccounts
    {
        EmployeeModel Create(IApplicantModel person);
    }
}