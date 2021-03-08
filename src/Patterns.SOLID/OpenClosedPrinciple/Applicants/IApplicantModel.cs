namespace Patterns.SOLID.OpenClosedPrinciple
{
    /// <summary>
    /// The same idea as in IAccounts represents this IApplicantModel. Instead of having person model in Accounts.Create method we have IApplicantModel.
    /// This behavior allows make us the application more flexible and independent.
    /// </summary>
    public interface IApplicantModel
    {
        string FirstName { get; set; }

        string LastName { get; set; }

        /// <summary>
        /// For this property every applicant model will have an account processor.
        /// </summary>
        IAccounts AccountProcessor { get; set; }
    }
}