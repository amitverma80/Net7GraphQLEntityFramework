using GraphQL;
using GraphQL.Types;
using GraphQLReal.InputTypes;
using GraphQLReal.Interfaces;
using GraphQLReal.Models;
using GraphQLReal.Types;

namespace GraphQLReal.Mutations
{
    public class JobMutation : ObjectGraphType
    {
        public JobMutation(IJobs jobService)
        {
            Field<JobType>("createJob", arguments: new QueryArguments(new QueryArgument<JobInputType> { Name = "job" }),
                resolve: context =>
                {
                    return jobService.Add(context.GetArgument<Job>("job"));
                });
        }
    }
}
