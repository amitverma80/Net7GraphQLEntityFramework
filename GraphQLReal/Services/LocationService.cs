using GraphQLReal.Data;
using GraphQLReal.Interfaces;
using GraphQLReal.Models;

namespace GraphQLReal.Services
{
    public class LocationService : ILocation
    {
        private readonly HRDataContext _context;
        public LocationService(HRDataContext context)
        {
            _context = context;
        }

        public Location Add(Location location)
        {
            throw new NotImplementedException();
        }

        public void Delete(Location location)
        {
            throw new NotImplementedException();
        }

        public List<Location> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Location> GetByCountry(int countryId)
        {
            throw new NotImplementedException();
        }

        public Location Update(Location location)
        {
            throw new NotImplementedException();
        }
    }
}
