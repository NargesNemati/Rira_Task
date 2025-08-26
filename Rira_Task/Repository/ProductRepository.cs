using Rira_Task.Data;
using Rira_Task.Models;

namespace Rira_Task.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext dbcontext;

        public ProductRepository(AppDbContext context)
        {
            dbcontext = context;
        }

        public List<Product> GetProductsByCategory1()
        {
            return dbcontext.Products.Where(p => p.Category == Categories.Category1).ToList();
        }

        public Product GetMostExpensiveProduct()
        {
            return dbcontext.Products.OrderByDescending(p => p.Price).FirstOrDefault();
        }

        public decimal GetTotalPrice()
        {
            return dbcontext.Products.Sum(p => p.Price);
        }

        public ILookup<Categories, Product> GroupProductsByCategory()
        {
            return dbcontext.Products.ToLookup(p => p.Category);
        }

        public decimal GetAveragePrice()
        {
            return dbcontext.Products.Average(p => p.Price);
        }


    }
}
