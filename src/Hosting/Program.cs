using GraphQL;
using GraphQL.Types;


using GraphQL.MicrosoftDI;
using GraphQL.Server;
using GraphQL.SystemTextJson;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

using MealToShopList.Data;
using MealToShopList.GraphQLApi;

using Microsoft.EntityFrameworkCore;


var connectionString = "server=192.168.2.1;user=MealToShopList-dev;password=MealToShopList-dev;database=MealToShopList-dev";

var serverVersion = new MariaDbServerVersion(new Version(10, 3, 27));

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<MealToShopListDbContext>(
    dbContextOptions => dbContextOptions
        .UseMySql(connectionString, serverVersion)
        .LogTo(Console.WriteLine, LogLevel.Information)
        .EnableSensitiveDataLogging()
        .EnableDetailedErrors());

builder.Services.AddGraphQL(graphQlBuilder => {
    graphQlBuilder
        .AddGraphTypes()
        .AddSchema<MealToShopListSchema>(GraphQL.DI.ServiceLifetime.Scoped)
        .AddSystemTextJson()
        .AddErrorInfoProvider(opt => opt.ExposeExceptionDetails = true);
});

builder.Services
    .AddLogging(builder => builder.AddConsole())
    .AddHttpContextAccessor();

var app = builder.Build();

app.UseGraphQLAltair("/");
app.UseWebSockets();
app.UseGraphQL("/graphql");


app.Run();
