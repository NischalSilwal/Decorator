namespace Decorator.Interfaces
{
    public class EmailMessageService : IMessageService
    {
        public void SendMessage(string message)
        {
            // Simulate sending an email
            Console.WriteLine($"Email sent: {message}");
        }
    }

}
