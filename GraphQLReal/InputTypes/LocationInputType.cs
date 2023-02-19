using GraphQL.Types;
using GraphQLReal.Models;

namespace GraphQLReal.InputTypes
{
    public class LocationInputType : InputObjectGraphType
    {
        public LocationInputType()
        {
            Field<IntGraphType>("id");
            Field<StringGraphType>("city");
            Field<StringGraphType>("name");
            Field<IntGraphType>("countryId");
        }
    }
}
