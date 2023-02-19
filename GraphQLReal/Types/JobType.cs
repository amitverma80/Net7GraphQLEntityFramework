using GraphQL.Types;
using GraphQLReal.Models;

namespace GraphQLReal.Types
{
    public class JobType:ObjectGraphType<Job>
    {
        public JobType()
        {
            Field(m => m.Id);
            Field(m => m.Title);
            Field(m => m.MinSalary);
            Field(m => m.MaxSalary);
        }
    }
}
