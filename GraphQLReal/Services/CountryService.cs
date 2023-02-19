using GraphQLReal.Data;
using GraphQLReal.Interfaces;
using GraphQLReal.Models;

namespace GraphQLReal.Services
{
    public class CountryService : ICountry
    {
        private readonly HRDataContext _context;
        public CountryService(HRDataContext context)
        {
            _context = context;
        }

        public Country Add(Country country)
        {
            throw new NotImplementedException();
        }

        public List<Country> GetAll()
        {
            throw new NotImplementedException();
        }

        public Country GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
