using OrderTracking.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderTracking.Model.DTO
{
    public class OrderUpdateDTO
    {
        public OrderStatus status {  get; set; }
    }
}
