using Rira_Task.Models;

namespace Rira_Task.Models
{
    public class ProductGroupDto
    {
        public string Category { get; set; }
        public List<ProductDto> Products { get; set; }
    }
}
