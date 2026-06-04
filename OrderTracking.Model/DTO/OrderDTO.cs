using OrderTracking.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderTracking.Model.DTO
{
    public class OrderDTO
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public OrderStatus Status { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
