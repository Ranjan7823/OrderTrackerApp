using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderTracking.Model.Entities;
using OrderTracking.Model.Enums;

namespace OrderTracking.Repository
{
    public static class InMemoryOrderStore
    {
        public static List<Order> Orders = new()
    {
        new Order
        {
            Id = 1,
            CustomerName = "John",
            Status = OrderStatus.Pending,
            CreatedAt = DateTime.UtcNow
        },

        new Order
        {
            Id = 2,
            CustomerName = "David",
            Status = OrderStatus.Shipped,
            CreatedAt = DateTime.UtcNow
        },

        new Order
        {
            Id = 3,
            CustomerName = "Mike",
            Status = OrderStatus.Delivered,
            CreatedAt = DateTime.UtcNow
        },

        new Order
        {
            Id = 4,
            CustomerName = "Robert",
            Status = OrderStatus.Pending,
            CreatedAt = DateTime.UtcNow
        }
    };

    }
}
