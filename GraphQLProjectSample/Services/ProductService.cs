using GraphQLProject.Data;
using GraphQLProject.Interfaces;
using GraphQLProject.Models;

namespace GraphQLProject.Services
{
    public class ProductService : IProduct
    {
        private readonly ProductDBContext _dbContext;

        public ProductService(ProductDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Product Add(Product product)
        {
            _dbContext.Products.Add(product);

            _dbContext.SaveChanges();

            return product;
        }

        public void Delete(int productId)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _dbContext.Products.ToList();
        }

        public Product Get(int id)
        {
            return _dbContext.Products.Where(p => p.Id == id).FirstOrDefault();
        }

        public Product Update(Product product)
        {
            var p = _dbContext.Products.Find(product.Id);

            p.Name = product.Name;
            p.Price= product.Price;

            _dbContext.Products.Update(p);

            return p;
        }
    }
}
