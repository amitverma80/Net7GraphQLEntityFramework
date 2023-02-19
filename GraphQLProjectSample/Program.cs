using GraphiQl;
using GraphQL.Server;
using GraphQL.Types;
using GraphQLProject.Data;
using GraphQLProject.Interfaces;
using GraphQLProject.Mutation;
using GraphQLProject.Query;
using GraphQLProject.Schema;
using GraphQLProject.Services;
using GraphQLProject.Type;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("SqlServerConnection");


builder.Services.AddTransient<IProduct, ProductService>();
builder.Services.AddTransient<ProductType>();
builder.Services.AddTransient<ProductQuery>();
builder.Services.AddTransient<ProductType>();
builder.Services.AddTransient<ProductMutation>();
builder.Services.AddTransient<ISchema, ProductSchema>();


//This will disable all metrices like Query Start Time, Query End Time. If not set false then query will return lot of data which is actually not required.
builder.Services.AddGraphQL(options =>
{
    options.EnableMetrics = false;
}).AddSystemTextJson();

builder.Services.AddDbContext<ProductDBContext>(options => options.UseSqlServer(connectionString));

var app = builder.Build();


// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

using (var scope = app.Services.CreateScope())
{
    using (var context = scope.ServiceProvider.GetService<ProductDBContext>())
    {
        context.Database.EnsureCreated();
    }
}

app.UseGraphiQl("/graphql");
app.UseGraphQL<ISchema>();

app.Run();

