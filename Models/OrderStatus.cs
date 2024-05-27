using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _2130_KhumaloCraft.Models
{
    [Table("OrderStatus")]
    public class OrderStatus
    {
        public int Id { get; set; }
        [Required, MaxLength(25)]
        public int StatusId { get; set; }
        [Required]
        public string StatusName { get; set; }
    }
}
