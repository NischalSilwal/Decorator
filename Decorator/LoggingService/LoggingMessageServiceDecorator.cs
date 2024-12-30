using Decorator.Interfaces;

namespace Decorator.LoggingService
{
    public class LoggingMessageServiceDecorator : IMessageService
    {
        private readonly IMessageService _innerService;
        private readonly ILogger<LoggingMessageServiceDecorator> _logger;

        public LoggingMessageServiceDecorator(
            IMessageService innerService,
            ILogger<LoggingMessageServiceDecorator> logger)
        {
            _innerService = innerService;
            _logger = logger;
        }

        public void SendMessage(string message)
        {
            // Log before calling the inner service
            _logger.LogInformation("Sending message: {Message}", message);

            // Delegate the actual sending to the inner service
            _innerService.SendMessage(message);

            // Log after the message is sent
            _logger.LogInformation("Message sent successfully.");
        }
    }

}
