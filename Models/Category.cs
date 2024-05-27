using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _2130_KhumaloCraft.Models
{
    
        [Table("Category")]
        public class Category
        {
            [Required]
            public int Id { get; set; }
            public string CatName { get; set; }
            public List<Product> products { get; set; }
        }
    }

