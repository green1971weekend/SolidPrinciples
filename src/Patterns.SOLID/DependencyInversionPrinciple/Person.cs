using Patterns.SOLID.DependencyInversionPrinciple.DIPInterfaces;

namespace Patterns.SOLID.DependencyInversionPrinciple
{
    public class Person : IPerson
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
    }
}
