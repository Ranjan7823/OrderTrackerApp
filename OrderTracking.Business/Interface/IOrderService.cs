using OrderTracking.Model.DTO;
using OrderTracking.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderTracking.Business.Interface
{
    public interface IOrderService
    {
        Task<IEnumerable<OrderDTO>> GetOrderList(OrderStatus? status, int page, int pageSize);
        Task Update(int id, OrderStatus status);
    }
}
