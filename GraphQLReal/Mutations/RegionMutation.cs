using GraphQL;
using GraphQL.Types;
using GraphQLReal.InputTypes;
using GraphQLReal.Interfaces;
using GraphQLReal.Models;
using GraphQLReal.Types;

namespace GraphQLReal.Mutations
{
    public class RegionMutation : ObjectGraphType
    {
        public RegionMutation(IRegions regionService)
        {
            Field<RegionType>("createRegion", arguments: new QueryArguments(new QueryArgument<RegionInputType> { Name = "region" }),
                resolve: context =>
                {
                    return regionService.Add(context.GetArgument<Regions>("region"));
                });
        }
    }
}
