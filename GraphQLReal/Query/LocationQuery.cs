using GraphQL.Types;
using GraphQLReal.Interfaces;
using GraphQLReal.Types;

namespace GraphQLReal.Query
{
    public class LocationQuery : ObjectGraphType
    {
        public LocationQuery(ILocation locationService)
        {
            Field<ListGraphType<LocationType>>("locations", resolve: context =>
            {
                return locationService.GetAll();
            });
        }
    }
}
