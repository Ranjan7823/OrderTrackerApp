using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderTracking.Model.Enums
{
    public enum OrderStatus
    {
        Pending = 1,
        Shipped= 2,
        ShipUnavailable= 3,
        Delivered= 4,
        Cancelled= 5,

    }

}
