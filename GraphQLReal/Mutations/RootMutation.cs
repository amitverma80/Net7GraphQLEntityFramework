using GraphQL.Types;


namespace GraphQLReal.Mutations
{
    public class RootMutation : ObjectGraphType
    {
        public RootMutation()
        {
            Field<CountryMutation>("countryMutation", resolve: context => new { });
            Field<DepartmentMutation>("departmentMutation", resolve: context => new { });
            Field<DependentMutation>("DependentMutation", resolve: context => new { });
            Field<EmployeeMutation>("employeeMutation", resolve: context => new { });
            Field<JobMutation>("jobMutation", resolve: context => new { });
            Field<LocationMutation>("locationMutation", resolve: context => new { });
            Field<RegionMutation>("regionMutation", resolve: context => new { });
        }
    }
}
