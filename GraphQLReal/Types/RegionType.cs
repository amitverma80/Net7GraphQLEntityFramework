using GraphQL.Types;
using GraphQLReal.Models;

namespace GraphQLReal.Types
{
    public class RegionType:ObjectGraphType<Regions>
    {
        public RegionType()
        {
            Field(m => m.Id);
            Field(m => m.Name);
            Field(m => m.Description);
        }
    }
}
