using GraphQLReal.Data;
using GraphQLReal.Interfaces;
using GraphQLReal.Models;

namespace GraphQLReal.Services
{
    public class RegionService : IRegions
    {
        private readonly HRDataContext _context;
        public RegionService(HRDataContext context)
        {
            _context = context;
        }

        public Regions Add(Regions region)
        {
            throw new NotImplementedException();
        }

        public void Delete(Regions region)
        {
            throw new NotImplementedException();
        }

        public List<Regions> GetAll()
        {
            throw new NotImplementedException();
        }

        public Regions GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Regions Update(Regions region)
        {
            throw new NotImplementedException();
        }
    }
}
