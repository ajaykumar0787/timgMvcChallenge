using OrderViewer.Repository.DbContexts;
using OrderViewer.Repository.Interfaces;
using OrderViewer.Repository.Repositories;
using OrderViewer.Web.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace OrderViewer.Web.Controllers.Api
{
    public class OrderViewerController : ApiController
    {
        private readonly IOrderRepository _orderRepository;

        public OrderViewerController()
        {
            _orderRepository = new OrderRepository(new OrderViewerDbContext(ConfigurationManager.ConnectionStrings["OrderViewerDb"].ToString()));
        }

        public IHttpActionResult Get()
        {
            try
            {
                var dbOrders = _orderRepository.GetAllOrders().ToList();
                return Ok(MapDbOrderToWebModel(dbOrders));
            }
            catch(Exception ex)
            {
                var errResponse = new HttpResponseMessage(HttpStatusCode.InternalServerError)
                {
                    Content = new StringContent("An error occurred while getting the orders." + ex.Message),
                    ReasonPhrase = "Error fetching orders"
                };

                throw new HttpResponseException(errResponse);
            }
        }

        private IList<Order> MapDbOrderToWebModel(List<Repository.Entities.Order> dbOrders)
        {
            return dbOrders.Select(o => new Order
            {
                Id = o.Id,
                ClientId = o.ClientId,
                ClientName = o.ClientName,
                OrderDate = o.OrderDate,
                GST = o.GST,
                Total = o.Total,
                OrderItems = o.OrderItems.Select(oi => new OrderItem
                {
                    Id = oi.Id,
                    ProductCode = oi.ProductCode,
                    Quantity = oi.Quantity,
                    TotalPrice = oi.TotalPrice
                }).ToList()
            }).ToList();
        }
    }
}