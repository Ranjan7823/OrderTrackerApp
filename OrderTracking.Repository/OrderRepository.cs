using OrderTracking.Model.Entities;
using OrderTracking.Model.Enums;
using OrderTracking.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderTracking.Repository
{
    public class OrderRepository : IOrderRepository
    {
        public async Task<IEnumerable<Order>> GetAll(OrderStatus? status, int page, int pageSize)
        {
            var query = InMemoryOrderStore.Orders.AsQueryable();
            if (status.HasValue)
            {
              query=  query.Where(x => x.Status == status);

            }
            query =query.Skip((page - 1) * pageSize).Take(pageSize);
            return await Task.FromResult(query.ToList());//query.ToList();
        }

        public async Task<Order?> GetById(int Id)
        {
            return await Task.FromResult(InMemoryOrderStore.Orders.FirstOrDefault(x => x.Id == Id));
        }

        public async Task Update(Order order)
        {
            var existingorder= InMemoryOrderStore.Orders.FirstOrDefault(x=>x.Id==order.Id);
            if (existingorder != null)
            {
                existingorder.Status = order.Status;
            }
            await Task.CompletedTask;
        }
    }
}
