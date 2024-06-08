using Asm_C5_Nhom6.Models;
using System.Collections.Generic;

namespace Asm_C5_Nhom6.Service
{
    public interface IResOrder
    {
        public IEnumerable<Order> GetOrder();
        public Order GetIDOrder(int id);

        public Order AddOrder(Order order);

        public Order UpdateOrder(int id, Order order);

        public Order DeleteOrder(int id);

    }
}
