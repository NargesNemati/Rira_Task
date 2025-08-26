
using System.ComponentModel.DataAnnotations;
namespace Rira_Task.Models
{
    public class ProductDto
    {

        [Required]
        public string Name { get; set; }

        [Required]
        public String Category { get; set; }

        [Required]
        public decimal Price { get; set; }
    }
}
