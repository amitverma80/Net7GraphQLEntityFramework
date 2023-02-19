using GraphQL;
using GraphQL.Types;
using GraphQLReal.InputTypes;
using GraphQLReal.Interfaces;
using GraphQLReal.Models;
using GraphQLReal.Types;

namespace GraphQLReal.Mutations
{
    public class EmployeeMutation : ObjectGraphType
    {
        public EmployeeMutation(IEmployee employeeService)
        {
            Field<EmployeeType>("createEmployee", arguments: new QueryArguments(new QueryArgument<EmployeeInputType> { Name = "employee" }),
                resolve: context =>
                {
                    return employeeService.Add(context.GetArgument<Employee>("employee"));
                });
        }
    }
}
