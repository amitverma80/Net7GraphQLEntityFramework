using GraphQL.Types;
using GraphQLReal.Models;

namespace GraphQLReal.InputTypes
{
    public class EmployeeInputType : InputObjectGraphType
    {
        public EmployeeInputType()
        {
            Field<IntGraphType>("id");
            Field<StringGraphType>("firstName");
            Field<StringGraphType>("lastName");
            Field<StringGraphType>("email");
            Field<IntGraphType>("mobile");
            Field<DateGraphType>("hireDate");
            Field<IntGraphType>("salary");
            Field<IntGraphType>("jobId");
        }
    }
}
