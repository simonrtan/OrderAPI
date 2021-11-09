using OrderAPI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OrderAPI.Models
{
    public class Order
    {
        public int ID { get; set; }
                
        public DateTime DateOrdered { get; set; }

        [Required(ErrorMessage = "Item Name must be specified")]
        public string ItemName { get; set; }

        public Person CustomerDetails { get; set; }

        public Status Status { get; set; }
    }
}
