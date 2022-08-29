using MealToShopList.Data;
using Microsoft.EntityFrameworkCore;

var connectionString = "server=192.168.2.1;user=MealToShopList-dev;password=MealToShopList-dev;database=MealToShopList-dev";

// Replace with your server version and type.
// Use 'MariaDbServerVersion' for MariaDB.
// Alternatively, use 'ServerVersion.AutoDetect(connectionString)'.
// For common usages, see pull request #1233.
var serverVersion = new MariaDbServerVersion(new Version(10, 3, 27));

// Replace 'YourDbContext' with the name of your own DbContext derived class.





var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<MealToShopListDbContext>(
    dbContextOptions => dbContextOptions
        .UseMySql(connectionString, serverVersion)
        .LogTo(Console.WriteLine, LogLevel.Information)
        .EnableSensitiveDataLogging()
        .EnableDetailedErrors());

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
