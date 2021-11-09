using OrderAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderAPI.Business
{
    public interface IOrderManagement
    {
        int CreateOrder(Order order);
        void DeleteOrder(int id);
        Order GetOrder(int id);
        void UpdateOrder(int id, Order updatedOrder);
    }

    public class OrderManagement : IOrderManagement
    {
        public OrderManagement()
        {

        }

        public Order GetOrder(int id)
        {
            return DummyData.DummyData.DummyOrders.FirstOrDefault(x => x.ID == id);
        }

        public int CreateOrder(Order order)
        {
            order.ID = new Random().Next(300, 1000);
            DummyData.DummyData.DummyOrders.Add(order);

            return order.ID;
        }

        public void UpdateOrder(int id, Order updatedOrder)
        {
            var order = DummyData.DummyData.DummyOrders.FirstOrDefault(x => x.ID == id);

            order.ItemName = updatedOrder.ItemName;
            order.Status = updatedOrder.Status;
            order.CustomerDetails = updatedOrder.CustomerDetails;
            order.DateOrdered = updatedOrder.DateOrdered;
        }

        public void DeleteOrder(int id)
        {
            DummyData.DummyData.DummyOrders.RemoveAll(x => x.ID == id);
        }
    }
}
