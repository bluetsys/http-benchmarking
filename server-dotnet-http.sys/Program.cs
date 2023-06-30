var builder = WebApplication.CreateBuilder(args);

builder.WebHost.UseHttpSys(
options =>
{
    options.AllowSynchronousIO = false;
    options.MaxAccepts = 100;
    options.Authentication.AllowAnonymous = true;
    options.MaxRequestBodySize = 30000000;
    options.MaxConnections = 100;
    options.UrlPrefixes.Add("http://127.0.0.1:8113/");
}
);

var app = builder.Build();

app.MapGet("/", async () => "Hello World");
app.MapGet("/health", async context =>
    {
        await context.Response.WriteAsJsonAsync(
            new
            {
                hostname = System.Environment.MachineName,
                language =
             new
             {
                 name = "dotnet",
                 version = System.Environment.Version,
             },
                web =
                new
                {
                    name = "aspnet",
                    version = System.Environment.Version,
                }
            });
    });

app.Run();