> dotnet
``` cs
var app = WebApplication.Create(args);

app.MapGet("/", (Func<string>)(() => "Hello World"));
app.MapGet("/health", (Func<string>)(() => System.Environment.MachineName));

app.Run();
```

``` bat
dotnet run --project .\server-dotnet-webapi\. --urls=http://*:8010/
```

> docker build
``` shell
docker build -t dotnet-webapi ./server-dotnet-webapi/.
```

> docker run
``` bash
docker run -d -p 8011:80 -name dotnet-webapi dotnet-webapi
```

---------------------------------------