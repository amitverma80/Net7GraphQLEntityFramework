using GraphQL.Types;
using GraphQLReal.Interfaces;
using GraphQLReal.Types;

namespace GraphQLReal.Query
{
    public class RegionQuery : ObjectGraphType
    {
        public RegionQuery(IRegions regionService)
        {
            Field<ListGraphType<RegionType>>("regions", resolve: context =>
            {
                return regionService.GetAll();
            });
        }
    }
}
