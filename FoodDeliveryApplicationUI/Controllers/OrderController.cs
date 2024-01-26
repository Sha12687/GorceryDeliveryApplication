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

        public OrderController(IOrderRepository orderRepository)
        {
            this.orderRepository = orderRepository;
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
    }
}