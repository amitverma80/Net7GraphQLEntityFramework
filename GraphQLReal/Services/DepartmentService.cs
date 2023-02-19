using GraphQLReal.Data;
using GraphQLReal.Interfaces;
using GraphQLReal.Models;

namespace GraphQLReal.Services
{
    public class DepartmentService : IDepartment
    {
        private readonly HRDataContext _context;
        public DepartmentService(HRDataContext context)
        {
            _context = context;
        }

        public Department Add(Department department)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Department> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Department> GetAllByLocation(int locationId)
        {
            throw new NotImplementedException();
        }

        public Department GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Department Update(Department department)
        {
            throw new NotImplementedException();
        }
    }
}
