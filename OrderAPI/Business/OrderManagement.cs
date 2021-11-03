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
    }

    public class OrderManagement : IOrderManagement
    {
        public OrderManagement()
        {

        }

        public int CreateOrder(Order order)
        {
            return 1;
        }

        
    }
}
