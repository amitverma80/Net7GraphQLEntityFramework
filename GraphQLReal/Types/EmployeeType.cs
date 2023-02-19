using GraphQL.Types;
using GraphQLReal.Models;

namespace GraphQLReal.Types
{
    public class EmployeeType : ObjectGraphType<Employee>
    {
        public EmployeeType()
        {
            Field(m => m.Id);
            Field(m => m.FirstName);
            Field(m => m.LastName);
            Field(m => m.Email);
            Field(m => m.Mobile);
            Field(m => m.HireDate, nullable: true);
            Field(m => m.Salary);
            Field(m => m.JobId);
        }
    }
}
