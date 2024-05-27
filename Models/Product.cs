using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _2130_KhumaloCraft.Models
{
    [Table("Product")]
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        
        public string? ImageUrl { get; set; }
        [Required]
        public int CategoryId { get; set; }
        public Category Categories;

        public List<OrderDetail> OrderDetails { get; set; }
        public List<CartDetail> CartDetails { get; set; }


        //public IEnumerable<SelectListItem> categories { get; set; }


        //public  ImageUrl { get; set; }

    }
}
