using Azure.Identity;

var builder = WebApplication.CreateBuilder(args);

builder.Configuration.AddAzureKeyVault(new Uri(builder.Configuration["KeyVaultURI"]), new DefaultAzureCredential());

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();