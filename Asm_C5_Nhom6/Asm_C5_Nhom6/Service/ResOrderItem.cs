using Asm_C5_Nhom6.Data;
using Asm_C5_Nhom6.Models;
using System.Collections.Generic;
using System.Linq;

namespace Asm_C5_Nhom6.Service
{
    public class ResOrderItem : IResOrderItem
    {
        private readonly AppDbcontext _context;

        public ResOrderItem(AppDbcontext context)
        {
            _context = context;
        }

        public OrderItem AddOrderItem(OrderItem orderItem)
        {
            _context.Add(orderItem);
            _context.SaveChanges();
            return orderItem;
        }

        public OrderItem DeleteOrderItem(int id)
        {
            var existingOrderItem = _context.OrderItems.Find(id);
            if (existingOrderItem == null)
            {
                return null;
            }
            else
            {
                _context.Remove(existingOrderItem);
                _context.SaveChanges();
                return existingOrderItem;
            }
        }

        public OrderItem GetIDOrderItem(int id)
        {
            var orderitem = _context.OrderItems.Find(id);
            if (orderitem == null)
            {
                return null;
            }


            return (OrderItem)orderitem;
        }

        public IEnumerable<OrderItem> GetOrderItem()
        {
            return _context.OrderItems.ToList();
        }

        public OrderItem UpdateOrderItem(int id, OrderItem orderitemupdate)
        {
            var existingOrderItem = _context.OrderItems.Find(id);
            if (existingOrderItem == null)
            {
                return null;
            }
            existingOrderItem.Quantity = orderitemupdate.Quantity;
            existingOrderItem.Price = orderitemupdate.Price;
            existingOrderItem.ProductId = orderitemupdate.ProductId;
            existingOrderItem.OrderId = orderitemupdate.OrderId;

            _context.Update(existingOrderItem);
            _context.SaveChanges();
            return existingOrderItem;
        }



        public IEnumerable<OrderItem> GetOrderItems()
        {
            return GetOrderItems();
        }

    }
}
