using Asm_C5_Nhom6.Models;
using Asm_C5_Nhom6.Service;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Asm_C5_Nhom6.Controllers
{
    public class OrderController : Controller
    {
        private readonly IResOrder _orderResponsitory;

        public OrderController(IResOrder order)
        {
            _orderResponsitory = order;
        }

        [HttpGet]
        public IEnumerable<Order> GetAll()
        {
            return _orderResponsitory.GetOrder();
        }

        [HttpGet("{id}")]
        public ActionResult<Order> GetId(int id)
        {
            if (id == 0)
            {
                return BadRequest("Value must be...");

            }
            return Ok(_orderResponsitory.GetIDOrder(id));
        }

        [HttpPost]
        public Order Add(Order order)
        {
            return _orderResponsitory.AddOrder(new Order
            {
                UserId = order.UserId,
                OrderId = order.OrderId,
                TotalAmount = order.TotalAmount,
                Status = order.Status,
                PaymentMethod = order.PaymentMethod,
                DeliveryStatus = order.DeliveryStatus,
                DeliveryPerson = order.DeliveryPerson,
                DeliveryDate = order.DeliveryDate,

            });
        }


        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var deleted = _orderResponsitory.DeleteOrder(id);
            if (deleted == null)
            {
                return NotFound("Order not found");
            }

            return Ok(deleted);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] Order updatedorder)
        {
            var updated = _orderResponsitory.UpdateOrder(id, updatedorder);
            if (updated == null)
            {
                return NotFound("Order not found");
            }

            return Ok(updated);
        }
    }
}
