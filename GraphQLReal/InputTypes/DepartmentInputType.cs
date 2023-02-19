using GraphQL.Types;
using GraphQLReal.Models;

namespace GraphQLReal.InputTypes
{
    public class DepartmentInputType : InputObjectGraphType
    {
        public DepartmentInputType()
        {
            Field<IntGraphType>("id");
            Field<StringGraphType>("name");
            Field<StringGraphType>("description");
            Field<IntGraphType>("locationId");
        }
    }
}
