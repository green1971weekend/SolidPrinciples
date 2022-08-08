namespace Patterns.SOLID.DependencyInversionPrinciple.DIPInterfaces
{
    public interface IMessageSender
    {
        void SendMessage(IPerson person, string message);
    }
}
