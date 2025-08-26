using Rira_Task.Models;

namespace Rira_Task.Repository
{
    public interface IProductRepository
    {
        List<Product> GetProductsByCategory1();
        Product GetMostExpensiveProduct();
        decimal GetTotalPrice();
        ILookup<Categories, Product> GroupProductsByCategory();
        decimal GetAveragePrice();
    }
}
