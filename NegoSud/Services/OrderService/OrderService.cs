using System;
using Microsoft.EntityFrameworkCore;
using NegoSud.Server.DTO.Order;

namespace NegoSud.Server.Services.OrderService
{
    public class OrderService : IOrderService // dossier service sert a stocker les classes responsable de la logique métier tel que gestion supplier, accés DB (utile de les séparer de celle logique présentation, (interaction avec user tel que MVC))
    {
        private readonly DataContext _context;

        public OrderService(DataContext context)
        {
            _context = context;
        }



        public async Task<OrderDto> AddOrder(PostOrder request)
        {
            var order = new Order();

            order.CreationDate = request.CreationDate;
            order.State = request.State;
            order.Quantity = request.Quantity;
            order.Archived = request.Archived;
            order.UserId = request.UserId;

          
            foreach (var item in request.Products)
            {
                var orderporduct = new OrderProduct { ProductId = item };
                order.Products.Add(orderporduct);

            }

            _context.Orders.Add(order);
            await _context.SaveChangesAsync();

            return new OrderDto {
                CreationDate = order.CreationDate,
                State = order.State,
                Quantity = order.Quantity,
                Archived = order.Archived,
                UserId = order.UserId};

        }

        public async Task<List<OrderDto>> GetAllOrders()
        {
            var order = await _context.Orders.ToListAsync();
            var listOrderDto = new List<OrderDto>();
            foreach (var item in order)
            {
                var orderdto = new OrderDto { Id = item.Id };
                listOrderDto.Add(orderdto);
            }
            return listOrderDto;
        }

        public async Task<OrderDto> GetSingleOrder(int id)
        {
            var order = await _context.Orders.FindAsync(id);
            if (order is null)
                return null;
            var orderdto = new OrderDto {
                CreationDate = order.CreationDate,
                State = order.State, Quantity =
                order.Quantity,
                Archived = order.Archived,
                UserId = order.UserId };

            return orderdto;
        }

    }
}
