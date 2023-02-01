using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NegoSud.Server.DTO;
using NegoSud.Server.Services.ProductService;

namespace NegoSud.Server.Controllers
{
    [Route("api/[controller]")]
    public class ProductController : Controller
    {
        private readonly IProductService _producService; // readonly pour assigné une seul fois et empeche toute modif

        public ProductController(IProductService producService)
        {
            _producService = producService; // permet d'injecter l'interface
        }

        [HttpGet]
        public async Task<ActionResult<List<ProductDto>>> GetAllProducts()// tous les clients. async task = asynchrome permet à l'appli de fonctionner pendant la tâche, évite que l'appli ralentisse ou s'arrete
        {
            return await _producService.GetAllProducts();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ProductDto>> GetSingleProduct(int id)
        {
            var result = await _producService.GetSingleProduct(id);
            if (result is null)
                return NotFound("Désolé mais ce produit n'existe que dans tes rêves :(");
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<List<ProductDto>>> AddProduct(PostProduct product)
        {
            var result = await _producService.AddProduct(product);
            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<List<ProductDto>>> UpdateProduct(int id, PostProduct request)
        {
            var result = await _producService.UpdateProduct(id, request);
            if (result is null)
                return NotFound("Désolé mais ce produit n'existe que dans tes rêves :(");
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<ProductDto>>> DeleteProduct(int id)
        {
            var result = await _producService.DeleteProduct(id);
            if (!result)
                return NotFound("Désolé mais ce produit n'existe que dans tes rêves :(");
            return Ok(result);
        }
    }
}

