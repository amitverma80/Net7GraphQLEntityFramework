/*
Important Links 

https://www.sqltutorial.org/sql-sample-database/

*/

using GraphiQl;
using GraphQL.Server;
using GraphQL.Types;
using GraphQLReal.Data;
using GraphQLReal.InputTypes;
using GraphQLReal.Interfaces;
using GraphQLReal.Mutations;
using GraphQLReal.Query;
using GraphQLReal.Schema;
using GraphQLReal.Services;
using GraphQLReal.Types;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("HRDataSQLServer");

builder.Services.AddTransient<ICountry, CountryService>();
builder.Services.AddTransient<IDepartment, DepartmentService>();
builder.Services.AddTransient<IDependents, DependentService>();
builder.Services.AddTransient<IEmployee, EmployeeService>();
builder.Services.AddTransient<IJobs, JobService>();
builder.Services.AddTransient<ILocation, LocationService>();
builder.Services.AddTransient<IRegions, RegionService>();

builder.Services.AddTransient<CountryType>();
builder.Services.AddTransient<DepartmentType>();
builder.Services.AddTransient<DependentType>();
builder.Services.AddTransient<EmployeeType>();
builder.Services.AddTransient<JobType>();
builder.Services.AddTransient<LocationType>();
builder.Services.AddTransient<RegionType>();

builder.Services.AddTransient<CountryInputType>();
builder.Services.AddTransient<DepartmentInputType>();
builder.Services.AddTransient<DependentInputType>();
builder.Services.AddTransient<EmployeeInputType>();
builder.Services.AddTransient<JobInputType>();
builder.Services.AddTransient<LocationInputType>();
builder.Services.AddTransient<RegionInputType>();


builder.Services.AddTransient<CountryQuery>();
builder.Services.AddTransient<DepartmentQuery>();
builder.Services.AddTransient<DependentQuery>();
builder.Services.AddTransient<EmployeeQuery>();
builder.Services.AddTransient<JobQuery>();
builder.Services.AddTransient<LocationQuery>();
builder.Services.AddTransient<RegionQuery>();

builder.Services.AddTransient<CountryMutation>();
builder.Services.AddTransient<DepartmentMutation>();
builder.Services.AddTransient<DependentMutation>();
builder.Services.AddTransient<EmployeeMutation>();
builder.Services.AddTransient<JobMutation>();
builder.Services.AddTransient<LocationMutation>();
builder.Services.AddTransient<RegionMutation>();

builder.Services.AddTransient<RootQuery>();
builder.Services.AddTransient<RootMutation>();


builder.Services.AddTransient<ISchema, RootSchema>();


builder.Services.AddGraphQL(options =>
{
    options.EnableMetrics = false;
}).AddSystemTextJson().AddErrorInfoProvider(o => o.ExposeExceptionStackTrace = true);


builder.Services.AddDbContext<HRDataContext>(options => options.UseSqlServer(connectionString));

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();


using (var scope = app.Services.CreateScope())
{
    using (var context = scope.ServiceProvider.GetService<HRDataContext>())
    {
        context?.Database.Migrate();
    }
}

app.UseGraphiQl("/graphql");
app.UseGraphQL<ISchema>();

app.Run();

