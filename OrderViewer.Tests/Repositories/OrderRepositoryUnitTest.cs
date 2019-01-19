using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderViewer.Repository.DbContexts;
using OrderViewer.Repository.Interfaces;
using OrderViewer.Repository.Repositories;
using System.Configuration;
using System.Linq;

namespace OrderViewer.Tests.Repositories
{
    [TestClass]
    public class OrderRepositoryUnitTest
    {
        private readonly IOrderRepository _orderRepository;

        public OrderRepositoryUnitTest()
        {
            _orderRepository = new OrderRepository(new OrderViewerDbContext(ConfigurationManager.ConnectionStrings["OrderViewerDb"].ToString()));
        }

        [TestMethod]
        public void TestGetAllOrders()
        {
            var orders = _orderRepository.GetAllOrders().ToList();

            Assert.IsTrue(orders.Any());
            Assert.IsTrue(orders.First().OrderItems.Any());
        }
    }
}
