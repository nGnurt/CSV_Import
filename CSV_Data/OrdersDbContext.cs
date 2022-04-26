using CSV_Import_Common;
using Microsoft.EntityFrameworkCore;

namespace CSV_Import_Data
{
    public class OrdersDbContext : DbContext
    {
        public OrdersDbContext(DbContextOptions<OrdersDbContext> options) : base(options)
        {            
        }

        private string connectionString;     
        
        public OrdersDbContext()
        {
            connectionString = Utils.GetConfig("ConnectionStrings:PostgreSQLDatabase");
        }
        public virtual DbSet<Orders> Orders { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql(connectionString);
            }            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {         
            modelBuilder.Entity<Orders>().HasIndex(o => o.OrderNumber)
                                         .IsUnique();            
        }
    }
}
