using GraphQL.Types;
using GraphQLReal.Models;

namespace GraphQLReal.InputTypes
{
    public class DependentInputType : InputObjectGraphType
    {
        public DependentInputType()
        {
            Field<IntGraphType>("id");
            Field<StringGraphType>("firstName");
            Field<StringGraphType>("lastName");
            Field<StringGraphType>("relationShip");
            Field<IntGraphType>("employeeId");
        }
    }
}
