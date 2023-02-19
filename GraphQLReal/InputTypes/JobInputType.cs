using GraphQL.Types;
using GraphQLReal.Models;

namespace GraphQLReal.InputTypes
{
    public class JobInputType : InputObjectGraphType
    {
        public JobInputType()
        {
            Field<IntGraphType>("id");
            Field<StringGraphType>("title");
            Field<IntGraphType>("minSalary");
            Field<IntGraphType>("maxSalary");
        }
    }
}
