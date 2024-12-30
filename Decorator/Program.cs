using Decorator.Interfaces;
using Decorator.LoggingService;

var builder = WebApplication.CreateBuilder(args);

// Register the base service
builder.Services.AddTransient<IMessageService, EmailMessageService>();

// Register the decorator
builder.Services.Decorate<IMessageService, LoggingMessageServiceDecorator>();

var app = builder.Build();

// Application services
app.MapGet("/", (IMessageService messageService) =>
{
    messageService.SendMessage("Hello, world!");
    return Results.Ok("Message sent!");
});

app.Run();
