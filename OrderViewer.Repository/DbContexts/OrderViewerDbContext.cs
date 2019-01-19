using OrderViewer.Repository.Entities;
using System.Data.Entity;

namespace OrderViewer.Repository.DbContexts
{
    public class OrderViewerDbContext : DbContext
    {
        public OrderViewerDbContext(string sqlConnectionString) : base(sqlConnectionString)
        {
            Configuration.AutoDetectChangesEnabled = false;
            Configuration.LazyLoadingEnabled = false;
            Configuration.ValidateOnSaveEnabled = false;
        }

        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
    }
}
