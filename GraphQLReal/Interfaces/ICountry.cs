using GraphQLReal.Models;

namespace GraphQLReal.Interfaces
{
    public interface ICountry
    {
        List<Country> GetAll();

        Country GetById(int id);

        Country Add (Country country);
    }
}
