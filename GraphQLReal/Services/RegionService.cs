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
            _context.Regions.Add(region);
            _context.SaveChanges();

            return region;
        }

        public void Delete(Regions region)
        {
            throw new NotImplementedException();
        }

        public List<Regions> GetAll()
        {
           return _context.Regions.ToList();
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
