var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World Gopal, here is a new get route from your app.!");

app.Run();
