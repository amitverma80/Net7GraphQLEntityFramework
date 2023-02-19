using GraphQL.Types;
using GraphQLReal.Interfaces;
using GraphQLReal.Types;

namespace GraphQLReal.Query
{
    public class CountryQuery:ObjectGraphType
    {
        public CountryQuery(ICountry countryService)
        {
            Field<ListGraphType<CountryType>>("countries", resolve: context => 
            { 
                return countryService.GetAll(); 
            });
        }
    }
}
