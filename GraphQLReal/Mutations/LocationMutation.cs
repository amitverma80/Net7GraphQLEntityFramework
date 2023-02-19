using GraphQL;
using GraphQL.Types;
using GraphQLReal.InputTypes;
using GraphQLReal.Interfaces;
using GraphQLReal.Models;
using GraphQLReal.Types;

namespace GraphQLReal.Mutations
{
    public class LocationMutation : ObjectGraphType
    {
        public LocationMutation(ILocation locationService)
        {
            Field<JobType>("createLocation", arguments: new QueryArguments(new QueryArgument<LocationInputType> { Name = "location" }),
                resolve: context =>
                {
                    return locationService.Add(context.GetArgument<Location>("location"));
                });
        }
    }
}
