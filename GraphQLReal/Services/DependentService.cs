using GraphQLReal.Data;
using GraphQLReal.Interfaces;
using GraphQLReal.Models;

namespace GraphQLReal.Services
{
    public class DependentService : IDependents
    {
        private readonly HRDataContext _context;
        public DependentService(HRDataContext context)
        {
            _context = context;
        }

        public Dependents Add(Dependents dependent)
        {
            throw new NotImplementedException();
        }

        public void Delete(Dependents dependent)
        {
            throw new NotImplementedException();
        }

        public List<Dependents> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Dependents> GetByEmployeeId(int employeeId)
        {
            throw new NotImplementedException();
        }

        public Dependents Update(Dependents dependent)
        {
            throw new NotImplementedException();
        }
    }
}
