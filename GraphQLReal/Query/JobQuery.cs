using GraphQL.Types;
using GraphQLReal.Interfaces;
using GraphQLReal.Types;

namespace GraphQLReal.Query
{
    public class JobQuery : ObjectGraphType
    {
        public JobQuery(IJobs jobsService)
        {
            Field<ListGraphType<JobType>>("jobs", resolve: context =>
            {
                return jobsService.GetAll();
            });
        }
    }
}
