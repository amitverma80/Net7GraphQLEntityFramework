using GraphQL.Language.AST;
using GraphQL.Types;
using GraphQLReal.Models;

namespace GraphQLReal.Types
{
    public class CountryType : ObjectGraphType<Country>
    {
        public CountryType()
        {
            Field(m => m.Id);
            Field(m => m.Name);
            Field(m => m.Description);
        }
    }
}
