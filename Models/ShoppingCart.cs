using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _2130_KhumaloCraft.Models
{
    [Table("Shopping Cart")]
    public class ShoppingCart
    {
        public int Id { get; set; }
       
        [Required]
        public int UserId { get; set; }
        public bool IsDeleted { get; set; } = false;
    }
}
