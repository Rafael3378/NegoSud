using System;
using NegoSud.Server.DTO.Order;

namespace NegoSud.Server.Services.OrderService
{
    public interface IOrderService // mise en oeuvre des méthodes du user service
    {
        Task<List<OrderDto>> GetAllOrders();

        Task<OrderDto> GetSingleOrder(int id);

        Task<OrderDto> AddOrder(PostOrder order);
    }
}

