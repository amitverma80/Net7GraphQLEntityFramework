using GraphQLProject.Models;

namespace GraphQLProject.Interfaces
{
    public interface IProduct
    {
        List<Product> GetAll();

        Product Get(int id);

        Product Add(Product product);
        
        Product Update(Product product);

        void Delete(int productId);

    }
}
