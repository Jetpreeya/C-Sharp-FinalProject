using Microsoft.EntityFrameworkCore;
using FinalPizzaProject.Models;

namespace FinalPizzaProject.Data
{
    public class ApplicationDbContext : DbContext 
    {
        public DbSet<PizzaOrder> PizzaOrders { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
            : base(options) 
        {

        }
    }
}
