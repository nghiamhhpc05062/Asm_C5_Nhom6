using Asm_C5_Nhom6.Data;
using Asm_C5_Nhom6.Models;
using System.Collections.Generic;
using System.Linq;

namespace Asm_C5_Nhom6.Service
{
    public class ResOrder : IResOrder
    {
        private readonly AppDbcontext _context;

        public Order AddOrder(Order order)
        {
            _context.Add(order);
            _context.SaveChanges();
            return order;
        }

        public Order DeleteOrder(int id)
        {
            var existingOrder = _context.Orders.Find(id);
            if (existingOrder == null)
            {
                return null;
            }
            else
            {
                _context.Remove(existingOrder);
                _context.SaveChanges();
                return existingOrder;
            }
        }

        public Order GetIDOrder(int id)
        {
            var order = _context.Orders.Find(id);
            if (order == null)
            {
                return null;
            }


            return (Order)order;
        }

        public IEnumerable<Order> GetOrder()
        {
            return _context.Orders.ToList();
        }

        public Order UpdateOrder(int id, Order orderupdate)
        {
            var existingOrder = _context.Orders.Find(id);
            if (existingOrder == null)
            {
                return null;
            }
            existingOrder.UserId = orderupdate.UserId;
            existingOrder.OrderDate = orderupdate.OrderDate;
            existingOrder.TotalAmount = orderupdate.TotalAmount;
            existingOrder.Status = orderupdate.Status;
            existingOrder.PaymentMethod = orderupdate.PaymentMethod;
            existingOrder.DeliveryStatus = orderupdate.DeliveryStatus;
            existingOrder.DeliveryPerson = orderupdate.DeliveryPerson;
            existingOrder.DeliveryDate = orderupdate.DeliveryDate;


            _context.Update(existingOrder);
            _context.SaveChanges();
            return existingOrder;

        }

        public IEnumerable<Order> GetOrders()
        {
            return GetOrders();
        }
    }
}
