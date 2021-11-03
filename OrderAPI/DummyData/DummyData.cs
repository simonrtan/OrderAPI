using OrderAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderAPI.DummyData
{
    public static class DummyData
    {
        public static List<Person> DummyPersons = new List<Person>()
            {
                new Person()
                {
                    ID = 100,
                    FirstName = "John",
                    LastName = "Doe",
                    Address = new Address()
                    {
                        Address1 = "600 Suffolk",
                        City = "Mississauga",
                        PostalCode = "L5A T8W",
                        Region = "ON"
                    }
                },
                new Person()
                {
                    ID = 200,
                    FirstName = "Jane",
                    LastName = "Doe",
                    Address = new Address()
                    {
                        Address1 = "60 Norwood",
                        City = "Ottawa",
                        PostalCode = "L5A T8W",
                        Region = "ON"
                    }
                },
            };

        public static List<Order> DummyOrders = new List<Order>()
            {
                new Order()
                {
                    ID = 1,
                    CustomerDetails = DummyPersons.First(x => x.ID == 100),
                    ShippingDetails = DummyPersons.First(x => x.ID == 100),
                    DateOrdered = DateTime.Now,
                    Status = Status.Ready
                },
                new Order()
                {
                    ID = 2,
                    CustomerDetails = DummyPersons.First(x => x.ID == 100),
                    ShippingDetails = DummyPersons.First(x => x.ID == 200),
                    DateOrdered = DateTime.Now,
                    Status = Status.Shipped
                },
            };
    }
}
