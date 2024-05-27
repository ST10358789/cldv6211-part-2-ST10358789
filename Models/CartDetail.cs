using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace _2130_KhumaloCraft.Models
{
    
        [Table("CartDetail")]
        public class CartDetail
        {
            [Key]
            public int Id { get; set; }
            [Required]

            public int ShoppingCart_ID { get; set; }
            [Required]
            public int ProductId { get; set; }
            public int Quantity { get; set; }
            public Product product { get; set; }

            public ShoppingCart shopcart { get; set; }
        }
    

}

