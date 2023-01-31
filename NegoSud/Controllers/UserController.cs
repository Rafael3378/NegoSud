using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NegoSud.Services.UserService;

namespace NegoSud.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NegoSudController : ControllerBase
    {
        private readonly IUserService _useService; // readonly pour assigné une seul fois et empeche toute modif

        public NegoSudController(IUserService customService)  
        {
            _useService = customService; // permet d'injecter l'interface
        }

        [HttpGet]
        public async Task<ActionResult<List<User>>> GetAllUsers()// tous les clients. async task = asynchrome permet à l'appli de fonctionner pendant la tâche, évite que l'appli ralentisse ou s'arrete
        {
            return await _useService.GetAllUsers();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetSingleUser(int id)// un seul client
        {
            var result = await _useService.GetSingleUser(id);
            if (result is null)
                return NotFound("Désolé mais ce client n'existe que dans tes réves :(");
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<List<User>>> AddUser(User customer)// Ajout de client
        {
            var result = await _useService.AddUser(customer);
            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<List<User>>> UpdateUser(int id, User request)// Mise à jour client
        {
            var result = await _useService.UpdateUser(id, request);
            if (result is null)
                return NotFound("Désolé mais ce client n'existe que dans tes réves :(");
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<User>>> DeleteUser(int id)// Mise à jour client
        {
            var result = await _useService.DeleteUser(id);
            if (result is null)
                return NotFound("Désolé mais ce client n'existe que dans tes réves :(");
            return Ok(result);
        }
    }
}
