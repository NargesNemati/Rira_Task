using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Rira_Task.Models;
using Rira_Task.Services;

namespace Rira_Task.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService service;
        private readonly IMapper mapper;

        public ProductsController(IProductService service, IMapper mapper)
        {
            this.service = service;
            this.mapper = mapper;
        }
        [HttpGet("category1")]
        public IActionResult GetByCategory1() {
            var products = service.GetProductsByCategory1();
            return Ok(products);
        }

        [HttpGet("most-expensive")]
        public IActionResult GetMostExpensive()
        {
            var product = service.GetMostExpensiveProduct();
            return Ok(product);
        }

        [HttpGet("total-price")]
        public IActionResult GetTotalPrice()
        {
            return Ok(service.GetTotalPrice());
        }

        [HttpGet("group-by-category")]
        public IActionResult GroupByCategory()
        {
            var products = service.GroupProductsByCategory();

            return Ok(products);
        }

        [HttpGet("average-price")]
        public IActionResult GetAveragePrice()
        {
            return Ok(service.GetAveragePrice());
        }
    }
}

