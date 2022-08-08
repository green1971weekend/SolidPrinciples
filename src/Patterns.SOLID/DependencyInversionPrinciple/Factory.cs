using Patterns.SOLID.DependencyInversionPrinciple.DIPInterfaces;

namespace Patterns.SOLID.DependencyInversionPrinciple
{
    /// <summary>
    /// This factory implementation is another way to implement Dependency inversion principle.
    /// The main method to implement dependency inversion principle is Dependency Injection.
    /// </summary>
    public static class Factory
    {
        /// <summary>
        /// Thanks to IMessageSender abstraction we can for example change creation of Emailer instance to Texter and therefore
        /// across all aplication we will get updated instance which won't break the application.
        /// Application break won't happen because of that we do not have any direct dependencies and we depend only on the abstractions, not 
        /// the implementations.
        /// </summary>
        /// <returns></returns>
        public static IMessageSender CreateMessageSender()
        {
            return new Emailer();
        }

        public static IPerson CreatePerson()
        {
            return new Person();
        }

        public static IChore CreateChore()
        {
            return new Chore(CreateLogger(), CreateMessageSender());
        }

        public static ILogger CreateLogger()
        {
            return new Logger();
        }
    }
}
