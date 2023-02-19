using GraphQLReal.Models;

namespace GraphQLReal.Interfaces
{
    public interface IDependents
    {
        List<Dependents> GetAll();

        List<Dependents> GetByEmployeeId(int employeeId);

        Dependents Add(Dependents dependent);

        Dependents Update(Dependents dependent);

        void Delete(Dependents dependent);
    }
}
