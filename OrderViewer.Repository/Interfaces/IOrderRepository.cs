using OrderViewer.Repository.Entities;
using System.Linq;

namespace OrderViewer.Repository.Interfaces
{
    public interface IOrderRepository
    {
        IQueryable<Order> GetAllOrders();
    }
}
