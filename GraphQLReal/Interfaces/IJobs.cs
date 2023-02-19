using GraphQLReal.Models;

namespace GraphQLReal.Interfaces
{
    public interface IJobs
    {
        List<Job> GetAll();

        Job GetById(int id);

        Job Add(Job job);

        Job Update(Job job);

        void Delete(Job job);
    }
}
