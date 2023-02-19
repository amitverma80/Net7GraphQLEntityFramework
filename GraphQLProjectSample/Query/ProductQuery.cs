using GraphQL;
using GraphQL.Types;
using GraphQLProject.Interfaces;
using GraphQLProject.Type;

namespace GraphQLProject.Query
{
    public class ProductQuery : ObjectGraphType
    {
        //From this we will methods defined in intrerface
        public ProductQuery(IProduct productService)
        {
            //For List in GraphQL use ListGraphType
            Field<ListGraphType<ProductType>>("products", resolve: context =>
            {
                return productService.GetAll();
            });

            Field<ProductType>("product", arguments: new QueryArguments(new QueryArgument<IntGraphType> { Name = "Id" }),
                resolve: context =>
                {
                    return productService.Get(context.GetArgument<int>("Id"));
                });
        }
    }
}
