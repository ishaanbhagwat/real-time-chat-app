var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// SignalR with Redis backplane
builder.Services.AddSignalR().AddStackExchangeRedis("localhost:6379");

// Add OpenAPI/Swagger services (optional for API documentation)
builder.Services.AddEndpointsApiExplorer();

var app = builder.Build();


// Enable static file serving (for the chat frontend)
app.UseDefaultFiles();
app.UseStaticFiles();

// Map the SignalR Hub
app.MapHub<ChatHub>("/chatHub");

app.Run();
