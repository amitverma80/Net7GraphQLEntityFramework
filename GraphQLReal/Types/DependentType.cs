using GraphQL.Types;
using GraphQLReal.Models;

namespace GraphQLReal.Types
{
    public class DependentType : ObjectGraphType<Dependents>
    {
        public DependentType()
        {
            Field(m => m.Id);
            Field(m => m.FirstName);
            Field(m => m.LastName);
            Field(m => m.RelationShip);
            Field(m => m.EmployeeId);
        }
    }
}
