using GraphQL.Types;
using GraphQLReal.Interfaces;
using GraphQLReal.Types;

namespace GraphQLReal.Query
{
    public class EmployeeQuery : ObjectGraphType
    {
        public EmployeeQuery(IEmployee employeeService)
        {
            Field<ListGraphType<EmployeeType>>("employees", resolve: context =>
            {
                return employeeService.GetAll();
            });
        }
    }
}
