using OrderAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderAPI.Models
{
    public class Order
    {
        public int ID { get; set; }

        public DateTime DateOrdered { get; set; }

        public Person CustomerDetails { get; set; }

        public Person ShippingDetails { get; set; }

        public Status Status { get; set; }
    }
}
