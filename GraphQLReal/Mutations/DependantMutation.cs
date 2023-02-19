using GraphQL;
using GraphQL.Types;
using GraphQLReal.InputTypes;
using GraphQLReal.Interfaces;
using GraphQLReal.Models;
using GraphQLReal.Types;

namespace GraphQLReal.Mutations
{
    public class DependentMutation : ObjectGraphType
    {
        public DependentMutation(IDependents DependentService)
        {
            Field<DependentType>("createDependents", arguments: new QueryArguments(new QueryArgument<DependentInputType> { Name = "Dependent" }),
                resolve: context =>
                {
                    return DependentService.Add(context.GetArgument<Dependents>("Dependent"));
                });
        }
    }
}
