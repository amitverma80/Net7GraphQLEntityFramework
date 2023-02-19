using GraphQL.Language.AST;
using GraphQL.Types;


namespace GraphQLReal.InputTypes
{
    public class CountryInputType : InputObjectGraphType
    {
        public CountryInputType()
        {
            Field<IntGraphType>("id");
            Field<StringGraphType>("name");
            Field<StringGraphType>("description");
        }
    }
}
