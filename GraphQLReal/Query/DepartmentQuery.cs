using GraphQL.Types;
using GraphQLReal.Interfaces;
using GraphQLReal.Types;

namespace GraphQLReal.Query
{
    public class DepartmentQuery:ObjectGraphType
    {
        public DepartmentQuery(IDepartment departmentService)
        {
            Field<ListGraphType<DepartmentType>>("departments", resolve: context => 
            { 
                return departmentService.GetAll();
            });
        }
    }
}
