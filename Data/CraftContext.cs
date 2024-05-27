using _2130_KhumaloCraft.Controllers;
using _2130_KhumaloCraft.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace _2130_KhumaloCraft.Data
{
    public class CraftContext : IdentityDbContext
    {
        public CraftContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<CartDetail> CartDetails { get; set; }
        public DbSet<OrderStatus> OrderStatus { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }






        public DbSet<AppUser> ApplicationUser { get; set; }
        
    }
}
