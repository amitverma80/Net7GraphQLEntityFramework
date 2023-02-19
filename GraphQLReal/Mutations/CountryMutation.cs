using GraphQL;
using GraphQL.Types;
using GraphQLReal.InputTypes;
using GraphQLReal.Interfaces;
using GraphQLReal.Models;
using GraphQLReal.Types;

namespace GraphQLReal.Mutations
{
    public class CountryMutation : ObjectGraphType
    {
        public CountryMutation(ICountry countryService)
        {
            Field<CountryType>("createCountry", arguments: new QueryArguments(new QueryArgument<CountryInputType> { Name = "country" }),
                resolve: context =>
                {
                    return countryService.Add(context.GetArgument<Country>("country"));
                });
        }
    }
}
