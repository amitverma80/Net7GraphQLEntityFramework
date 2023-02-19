using GraphQL.Types;

namespace GraphQLReal.Query
{
    public class RootQuery : ObjectGraphType
    {
        public RootQuery()
        {
            Field<CountryQuery>("countryQuery", resolve: context => new { });
            Field<DepartmentQuery>("departmentQuery", resolve: context => new { });
            Field<DependentQuery>("dependentQuery", resolve: context => new { });
            Field<EmployeeQuery>("employeeQuery", resolve: context => new { });
            Field<JobQuery>("jobQuery", resolve: context => new { });
            Field<LocationQuery>("locationQuery", resolve: context => new { });
            Field<RegionQuery>("regionQuery", resolve: context => new { });
        }
    }
}
