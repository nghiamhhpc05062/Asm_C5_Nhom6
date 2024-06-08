using Asm_C5_Nhom6.Models;
using Asm_C5_Nhom6.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Asm_C5_Nhom6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderItemController : ControllerBase
    {
        private readonly IResOrderItem _orderitemResponsitory;

        public OrderItemController(IResOrderItem orderitem)
        {
            _orderitemResponsitory = orderitem;
        }

        [HttpGet]
        public IEnumerable<OrderItem> GetAll()
        {
            return _orderitemResponsitory.GetOrderItem();
        }

        [HttpGet("{id}")]
        public ActionResult<OrderItem> GetId(int id)
        {
            if (id == 0)
            {
                return BadRequest("Value must be...");

            }
            return Ok(_orderitemResponsitory.GetIDOrderItem(id));
        }

        [HttpPost]
        public OrderItem Add(OrderItem orderitem)
        {
            return _orderitemResponsitory.AddOrderItem(new OrderItem
            {
                Quantity = orderitem.Quantity,
                Price = orderitem.Price,
                ProductId = orderitem.ProductId,
                OrderId = orderitem.OrderId,

            });
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var deleted = _orderitemResponsitory.DeleteOrderItem(id);
            if (deleted == null)
            {
                return NotFound("OrderItem not found");
            }

            return Ok(deleted);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] OrderItem updatedorderitem)
        {
            var updated = _orderitemResponsitory.UpdateOrderItem(id, updatedorderitem);
            if (updated == null)
            {
                return NotFound("OrderItem not found");
            }

            return Ok(updated);
        }
    }
}
