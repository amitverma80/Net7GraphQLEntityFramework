using GraphQL.Types;
using GraphQLReal.Models;

namespace GraphQLReal.Types
{
    public class LocationType : ObjectGraphType<Location>
    {
        public LocationType()
        {
            Field(m => m.Id);
            Field(m => m.City);
            Field(m => m.Name);
            Field(m => m.CountryId);
        }
    }
}
