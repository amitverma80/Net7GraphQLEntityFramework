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
        /*
        query { regionQuery{ regions{ id, name, description } } }         
         */
        public List<Regions> GetAll()
        {
            return _context.Regions.ToList();
        }

        /*
         {
          regionQuery {     
            region (id:2){       
              id
              name 
              description
            }
          }
        }         
        */
        public Regions GetById(int id)
        {
            var result = _context.Regions.Where(x => x.Id == id).FirstOrDefault();

            if (result != null)
            {
                return result;
            }
            return new Regions();
        }

        public Regions Update(Regions region)
        {
            throw new NotImplementedException();
        }
    }
}
