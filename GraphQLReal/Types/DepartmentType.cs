using GraphQL.Types;
using GraphQLReal.Models;

namespace GraphQLReal.Types
{
    public class DepartmentType : ObjectGraphType<Department>
    {
        public DepartmentType()
        {
            Field(m => m.Id);
            Field(m => m.Name);
            Field(m => m.Description);
            Field(m => m.LocationId);
        }
    }
}
