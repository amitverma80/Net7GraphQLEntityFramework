using GraphQL;
using GraphQL.Types;
using GraphQLReal.InputTypes;
using GraphQLReal.Interfaces;
using GraphQLReal.Models;
using GraphQLReal.Types;

namespace GraphQLReal.Mutations
{
    public class DepartmentMutation : ObjectGraphType
    {
        public DepartmentMutation(IDepartment departmentService)
        {
            Field<CountryType>("createDepartment", arguments: new QueryArguments(new QueryArgument<DepartmentInputType> { Name = "department" }),
                resolve: context =>
                {
                    return departmentService.Add(context.GetArgument<Department>("department"));
                });
        }
    }
}
