using Rira_Task.Models;

namespace Rira_Task.Services
{
        public interface IProductService
        {
            List<ProductDto> GetProductsByCategory1();
            ProductDto GetMostExpensiveProduct();
            decimal GetTotalPrice();
            List<ProductGroupDto> GroupProductsByCategory();
            decimal GetAveragePrice();
        }

}
