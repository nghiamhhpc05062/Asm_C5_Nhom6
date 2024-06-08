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
            throw new System.NotImplementedException();
        }

        public OrderItem DeleteOrderItem(int id)
        {
            throw new System.NotImplementedException();
        }

        public OrderItem GetIDOrderItem(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<OrderItem> GetOrderItem()
        {
            throw new System.NotImplementedException();
        }

        public OrderItem UpdateOrderItem(int id, OrderItem orderItem)
        {
            throw new System.NotImplementedException();
        }
    }
}
