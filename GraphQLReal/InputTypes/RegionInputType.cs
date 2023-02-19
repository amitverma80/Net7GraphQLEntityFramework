using GraphQL.Types;
using GraphQLReal.Models;

namespace GraphQLReal.InputTypes
{
    public class RegionInputType : InputObjectGraphType
    {
        public RegionInputType()
        {
            Field<IntGraphType>("id");
            Field<StringGraphType>("name");
            Field<StringGraphType>("description");
        }
    }
}
