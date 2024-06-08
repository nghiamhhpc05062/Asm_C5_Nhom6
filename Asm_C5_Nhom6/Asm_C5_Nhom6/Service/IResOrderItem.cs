using Asm_C5_Nhom6.Models;
using System.Collections.Generic;

namespace Asm_C5_Nhom6.Service
{
    public interface IResOrderItem
    {
        public IEnumerable<OrderItem> GetOrderItem();
        public OrderItem GetIDOrderItem(int id);

        public OrderItem AddOrderItem(OrderItem orderItem);

        public OrderItem UpdateOrderItem(int id, OrderItem orderItem);

        public OrderItem DeleteOrderItem(int id);

    }
}
