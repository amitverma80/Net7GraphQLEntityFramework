using GraphQLReal.Data;
using GraphQLReal.Interfaces;

namespace GraphQLReal.Services
{
    public class JobService : IJobs
    {
        private readonly HRDataContext _context;
        public JobService(HRDataContext context)
        {
            _context = context;
        }

        public Models.Job Add(Models.Job job)
        {
            throw new NotImplementedException();
        }

        public void Delete(Models.Job job)
        {
            throw new NotImplementedException();
        }

        public List<Models.Job> GetAll()
        {
            throw new NotImplementedException();
        }

        public Models.Job GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Models.Job Update(Models.Job job)
        {
            throw new NotImplementedException();
        }
    }
}
