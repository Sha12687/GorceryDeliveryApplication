using FoodDeliveryApplicationUI.Models;
using FoodDeliveryDAL;
using FoodDeliveryDAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FoodDeliveryApplicationUI.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderRepository orderRepository;
        private readonly IOrderDetailRepository orderDetailRepository;

        public OrderController(IOrderRepository orderRepository ,IOrderDetailRepository orderDetailRepository)
        {
            this.orderRepository = orderRepository;
            this.orderDetailRepository = orderDetailRepository;
        }
        // GET: Order
        public ActionResult InCompleteOrders()
        {
            var orders = orderRepository.GetIncompleteOrders();
            var productViewModels = orders
           .SelectMany(od => od.OrderDetails.Select(detail => new InCompleteOrderDetails
           {
               CustomerId=detail.Order.CustomerId,
               OrderId=detail.Order.OrderId,
               OrderDetails=detail.OrderDetailId,
               OrderStatus = detail.OrderStatus,
           }))
           .ToList();

            return View(productViewModels);
        }

        public ActionResult UpdateOrder(int Id)
        {
               var ShowOrderToUpdateStatus = orderDetailRepository.GetOrderDetailsByOrderId(Id);
        List<UpdateOrderStatusModel> orderToUpdate = ShowOrderToUpdateStatus.Select(data =>
         new UpdateOrderStatusModel
         {
           ProductName = data.ProductName,
           Quantity = data.Quantity,
           OrderId=Id,
         }).ToList(); // Convert IEnumerable to List
            return View(orderToUpdate);
        }

        [HttpPost]
        public ActionResult UpdateOrderStatus(int orderId, int status)
        {
            // Your logic to update the order status based on the orderId and status parameter
            // For example:
            // OrderService.UpdateOrderStatus(orderId, status);

            // Redirect to a different action or return a view
            return RedirectToAction("InCompleteOrders", "Order"); // Redirect to the home page, change it according to your application flow
        }
    }
}