using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderTracking.Model.Entities;
using OrderTracking.Model.Enums;
using OrderTracking.Model.DTO;


namespace OrderTracking.Repository.Interface
{
    public interface IOrderRepository
    {
        Task<IEnumerable<Order>> GetAll(OrderStatus? status, int page, int pageSize);
        Task<Order?> GetById(int Id);
        Task Update(Order order);

    }
}
