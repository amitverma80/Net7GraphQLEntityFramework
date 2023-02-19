using GraphQL;
using GraphQL.Types;
using GraphQLProject.Interfaces;
using GraphQLProject.Models;
using GraphQLProject.Type;

namespace GraphQLProject.Mutation
{
    public class ProductMutation : ObjectGraphType
    {
        public ProductMutation(IProduct productService)
        {
            Field<ProductType>("createProduct", arguments: new QueryArguments(new QueryArgument<ProductInputType> { Name = "product" }),
                resolve: context =>
                {
                    return productService.Add(context.GetArgument<Product>("product"));
                });

            Field<ProductType>("updateProduct", arguments: new QueryArguments(new QueryArgument<ProductInputType> { Name = "product" }),
                resolve: context =>
                {
                    return productService.Update(context.GetArgument<Product>("product"));
                });

            Field<ProductType>("deleteProduct", arguments: new QueryArguments(new QueryArgument<IntGraphType> { Name = "Id" }),
                resolve: context =>
                {
                    productService.Delete(context.GetArgument<int>("Id"));

                    return "The product has been deleted";
                });
        }
    }
}
