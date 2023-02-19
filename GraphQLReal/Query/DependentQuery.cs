using GraphQL.Types;
using GraphQLReal.Interfaces;
using GraphQLReal.Types;

namespace GraphQLReal.Query
{
    public class DependentQuery : ObjectGraphType
    {
        public DependentQuery(IDependents dependentsService)
        {
            Field<ListGraphType<DependentType>>("dependents", resolve: context =>
            {
                return dependentsService.GetAll();
            });
        }
    }
}
