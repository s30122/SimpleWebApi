var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "web1");

app.Run();