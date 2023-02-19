using GraphQLReal.Models;

namespace GraphQLReal.Interfaces
{
    public interface ILocation
    {
        List<Location> GetAll();

        List<Location> GetByCountry(int countryId);

        Location Add(Location location);

        Location Update(Location location);

        void Delete(Location location);
    }
}
