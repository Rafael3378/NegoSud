using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NegoSud.Services.CustomerService;

namespace NegoSud.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NegoSudController : ControllerBase
    {
        private readonly ICustomerService _customService; // readonly pour assigné une seul fois et empeche toute modif

        public NegoSudController(ICustomerService customService)  
        {
            _customService = customService; // permet d'injecter l'interface
        }

        [HttpGet]
        public async Task<ActionResult<List<Customer>>> GetAllCustomers()// tous les clients. async task = asynchrome permet à l'appli de fonctionner pendant la tâche, évite que l'appli ralentisse ou s'arrete
        {
            return await _customService.GetAllCustomers();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Customer>> GetSingleCustomer(int id)// un seul client
        {
            var result = await _customService.GetSingleCustomer(id);
            if (result is null)
                return NotFound("Désolé mais ce client n'existe que dans tes réves :(");
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<List<Customer>>> AddCustomer(Customer customer)// Ajout de client
        {
            var result = await _customService.AddCustomer(customer);
            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<List<Customer>>> UpdateCustomer(int id, Customer request)// Mise à jour client
        {
            var result = await _customService.UpdateCustomer(id, request);
            if (result is null)
                return NotFound("Désolé mais ce client n'existe que dans tes réves :(");
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Customer>>> DeleteCustomer(int id)// Mise à jour client
        {
            var result = await _customService.DeleteCustomer(id);
            if (result is null)
                return NotFound("Désolé mais ce client n'existe que dans tes réves :(");
            return Ok(result);
        }
    }
}
