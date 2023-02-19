using GraphQL.Types;

namespace GraphQLProject.Type
{
    public class ProductInputType : InputObjectGraphType
    {
        public ProductInputType()
        {
            Field<IntGraphType>("Id");
            
            Field<StringGraphType>("Name");

            Field<IntGraphType>("Price");
        }
    }
}
