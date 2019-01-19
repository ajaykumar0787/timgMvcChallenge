using OrderViewer.Repository.DbContexts;
using OrderViewer.Repository.Entities;
using OrderViewer.Repository.Interfaces;
using System.Linq;

namespace OrderViewer.Repository.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly OrderViewerDbContext _orderViewerDbContext;

        public OrderRepository(OrderViewerDbContext orderViewerDbContext)
        {
            _orderViewerDbContext = orderViewerDbContext;
        }

        public IQueryable<Order> GetAllOrders()
        {
            return _orderViewerDbContext.Orders.Include("OrderItems");
        }
    }
}
