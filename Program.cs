var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
app.MapGet("/", () =>
{
    return $"App2:v4";
});
app.Run();
