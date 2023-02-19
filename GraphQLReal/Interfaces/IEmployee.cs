using GraphQLReal.Models;

namespace GraphQLReal.Interfaces
{
    public interface IEmployee
    {
        List<Employee> GetAll();

        Employee GetById(int id);

        Employee Add(Employee employee);

        Employee Update(Employee employee);

        void Delete(Employee employee);
    }
}
