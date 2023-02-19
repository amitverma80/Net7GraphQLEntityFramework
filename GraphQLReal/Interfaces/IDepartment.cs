using GraphQLReal.Models;

namespace GraphQLReal.Interfaces
{
    public interface IDepartment
    {
        List<Department> GetAll();

        List<Department> GetAllByLocation(int locationId);

        Department GetById(int id);

        Department Add(Department department);

        Department Update(Department department);

        void Delete(int id);
    }
}
