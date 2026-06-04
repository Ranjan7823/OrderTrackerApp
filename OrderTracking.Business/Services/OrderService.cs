using OrderTracking.Business.Interface;
using OrderTracking.Model.DTO;
using OrderTracking.Model.Enums;
using OrderTracking.Model.Exceptions;
using OrderTracking.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderTracking.Business.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;
        public OrderService( IOrderRepository orderRepository) {
            _orderRepository = orderRepository;
        }
        public async Task<IEnumerable<OrderDTO>> GetOrderList(OrderStatus? status, int page, int pageSize)
        {
            var orders = await _orderRepository.GetAll(status, page, pageSize);
            return orders.Select(order =>
                new OrderDTO
                {
                    Id = order.Id,
                    CustomerName = order.CustomerName,
                    Status = order.Status,
                    CreatedAt = DateTime.UtcNow,

                }
            );
        }

        public async Task Update(int id, OrderStatus newstatus)
        {
            var order = await _orderRepository.GetById(id);
            if (order == null)
            {
                throw new InvalidOrderException($"Order {id} is not found");
            }
            ValidateTransition(order.Status, newstatus);
            order.Status = newstatus;
            await _orderRepository.Update(order);

        }
       private static void ValidateTransition(
       OrderStatus currentStatus,
       OrderStatus newStatus)
        {
            if (currentStatus == OrderStatus.Pending &&
                newStatus == OrderStatus.Shipped)
            {
                return;
            }

            if (currentStatus == OrderStatus.Shipped &&
                newStatus == OrderStatus.Delivered)
            {
                return;
            }

            if ((currentStatus == OrderStatus.Pending ||
                 currentStatus == OrderStatus.Shipped)
                 && newStatus == OrderStatus.Cancelled)
            {
                return;
            }

            throw new InvalidOrderException(
                $"Invalid transition from {currentStatus} to {newStatus}");
        }
    }
}
