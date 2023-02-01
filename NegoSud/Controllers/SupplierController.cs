using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NegoSud.Server.DTO;
using NegoSud.Server.Services.SupplierService;

namespace NegoSud.Server.Controllers
{
    [Route("api/[controller]")]
    public class SupplierController : ControllerBase
    {
        private readonly ISupplierService _suppliService; // readonly pour assigné une seul fois et empeche toute modif

        public SupplierController(ISupplierService suppliService)
        {
            _suppliService = suppliService; // permet d'injecter l'interface
        }

        [HttpGet]
        public async Task<ActionResult<List<SupplierDto>>> GetAllSuppliers()// tous les clients. async task = asynchrome permet à l'appli de fonctionner pendant la tâche, évite que l'appli ralentisse ou s'arrete
        {
            return await _suppliService.GetAllSuppliers();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<SupplierDto>> GetSingleSupplier(int id)
        {
            var result = await _suppliService.GetSingleSupplier(id);
            if (result is null)
                return NotFound("Désolé mais ce fournisseur n'existe que dans tes rêves :(");
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<List<SupplierDto>>> AddSupplier(PostSupplier supplier)
        {
            var result = await _suppliService.AddSupplier(supplier);
            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<List<SupplierDto>>> UpdateSupplier(int id, PostSupplier request)
        {
            var result = await _suppliService.UpdateSupplier(id, request);
            if (result is null)
                return NotFound("Désolé mais ce fournisseur n'existe que dans tes rêves :(");
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<SupplierDto>>> DeleteSupplier(int id)
        {
            var result = await _suppliService.DeleteSupplier(id);
            if (!result)
                return NotFound("Désolé mais ce fournisseur n'existe que dans tes rêves :(");
            return Ok(result);
        }
    }
}
