using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NegoSud.Server.DTO.Order;
using NegoSud.Server.Services.OrderService;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NegoSud.Server.Controllers
{
    [Route("api/[controller]")]
    public class OrderController : Controller
    {
        private readonly IOrderService _orderService; // readonly pour assigné une seul fois et empeche toute modif

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService; // permet d'injecter l'interface
        }

        [HttpGet]
        public async Task<ActionResult<List<OrderDto>>> GetAllOrders()// tous les clients. async task = asynchrome permet à l'appli de fonctionner pendant la tâche, évite que l'appli ralentisse ou s'arrete
        {
            return await _orderService.GetAllOrders();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<OrderDto>> GetSingleOrder(int id)
        {
            var result = await _orderService.GetSingleOrder(id);
            if (result is null)
                return NotFound("Désolé mais ce commande n'existe que dans tes rêves :(");
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<List<OrderDto>>> AddOrder(PostOrder order)
        {
            var result = await _orderService.AddOrder(order);
            return Ok(result);
        }

    }
}


