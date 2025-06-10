var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/api/stream", () => TypedResults.Ok("Stream API ready"));

app.Run();
