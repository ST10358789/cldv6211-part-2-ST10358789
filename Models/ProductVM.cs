using System.ComponentModel.DataAnnotations;

namespace _2130_KhumaloCraft.Models
{
    public class ProductVM
    {
        
            public int Id { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public double Price { get; set; }
            public string Category { get; set; }
            public string? ImageUrl { get; set; }
            [Required]
            public int CategoryId { get; set; }
            public Category Categories;

        }
    }

