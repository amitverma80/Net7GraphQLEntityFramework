using GraphQLReal.Data;
using GraphQLReal.Interfaces;
using GraphQLReal.Models;

namespace GraphQLReal.Services
{
    public class EmployeeService : IEmployee
    {
        private readonly HRDataContext _context;
        public EmployeeService(HRDataContext context)
        {
            _context = context;
        }
        public Employee Add(Employee employee)
        {
            throw new NotImplementedException();
        }

        public void Delete(Employee employee)
        {
            throw new NotImplementedException();
        }

        public List<Employee> GetAll()
        {
            throw new NotImplementedException();
        }

        public Employee GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Employee Update(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}
