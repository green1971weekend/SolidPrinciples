namespace Patterns.SOLID.DependencyInversionPrinciple.DIPInterfaces
{
    public interface IPerson
    {
        string EmailAddress { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string PhoneNumber { get; set; }
    }
}