using GraphQLReal.Models;

namespace GraphQLReal.Interfaces
{
    public interface IRegions
    {
        List<Regions> GetAll();

        Regions GetById(int id);

        Regions Add(Regions region);

        Regions Update(Regions region);

        void Delete(Regions region);
    }
}
