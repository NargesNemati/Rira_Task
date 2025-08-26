using AutoMapper;
using Rira_Task.Models;
using Rira_Task.Repository;
using System.Text.RegularExpressions;

namespace Rira_Task.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repo;
        private readonly IMapper mapper;

        public ProductService(IProductRepository repo, IMapper mapper)
        {
            _repo = repo;
            this.mapper = mapper;
        }

        public List<ProductDto> GetProductsByCategory1()
        {
            var products = _repo.GetProductsByCategory1();
            return mapper.Map<List<ProductDto>>(products);
        }
        public ProductDto GetMostExpensiveProduct()
        {
            var product = _repo.GetMostExpensiveProduct();
            return mapper.Map<ProductDto>(product);
        }
        public decimal GetTotalPrice()
        { 
            return _repo.GetTotalPrice();
        }
        public List<ProductGroupDto> GroupProductsByCategory()
        {
            var grouped =  _repo.GroupProductsByCategory();
            return grouped.Select(g => new ProductGroupDto
            {
                Category = g.Key.ToString(),
                Products = g.Select(p => mapper.Map<ProductDto>(p)).ToList()
            }).ToList();
        }
        public decimal GetAveragePrice()
        {
            return _repo.GetAveragePrice();
        }
    }
}
