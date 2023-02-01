using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NegoSud.Server.DTO;
using NegoSud.Server.Services.UserService;

namespace NegoSud.Server.Controllers
{
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private readonly IUserService _useService; // readonly pour assigné une seul fois et empeche toute modif

        public UserController(IUserService customService)  
        {
            _useService = customService; // permet d'injecter l'interface
        }

        [HttpGet]
        public async Task<ActionResult<List<UserDto>>> GetAllUsers()// tous les clients. async task = asynchrome permet à l'appli de fonctionner pendant la tâche, évite que l'appli ralentisse ou s'arrete
        {
            return await _useService.GetAllUsers();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<UserDto>> GetSingleUser(int id)// un seul client
        {
            var result = await _useService.GetSingleUser(id);
            if (result is null)
                return NotFound("Désolé mais cet utilisateur n'existe que dans tes rêves :(");
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<List<UserDto>>> AddUser(PostUser user)// Ajout de client
        {
            var result = await _useService.AddUser(user);
            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<List<UserDto>>> UpdateUser(int id, PostUser request)// Mise à jour client
        {
            var result = await _useService.UpdateUser(id, request);
            if (result is null)
                return NotFound("Désolé mais cet utilisateur n'existe que dans tes rêves :(");
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<UserDto>>> DeleteUser(int id)// Mise à jour client
        {
            var result = await _useService.DeleteUser(id);
            if (!result)
                return NotFound("Désolé mais cet utilisateur n'existe que dans tes rêves :(");
            return Ok(result);
        }
    }
}
