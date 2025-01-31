﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace _2130_KhumaloCraft.Models
{
    
        [Table("Order")]
        public class Order
        {
            [Key]
            public int Id { get; set; }
            [Required]
            public string UserId { get; set; }
            public DateTime DateTime { get; set; } = DateTime.Now;
            [Required]
            public int OrderStatusId { get; set; }
            public bool IsDeleted { get; set; } = false;
            public List<OrderDetail> OrderDetails { get; set; }
            public OrderStatus OrderStat { get; set; }

        }
    }

