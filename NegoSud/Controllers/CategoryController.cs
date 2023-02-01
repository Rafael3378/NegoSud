using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NegoSud.Server.DTO;
using NegoSud.Server.Services.CategoryService;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NegoSud.Server.Controllers
{
    [Route("api/[controller]")]
    public class CategoryController : Controller
    {
        private readonly ICategoryService _cateService; // readonly pour assigné une seul fois et empeche toute modif

        public CategoryController(ICategoryService cateService)
        {
            _cateService = cateService; // permet d'injecter l'interface
        }

        [HttpGet]
        public async Task<ActionResult<List<CategoryDto>>> GetAllCategorys()// tous les clients. async task = asynchrome permet à l'appli de fonctionner pendant la tâche, évite que l'appli ralentisse ou s'arrete
        {
            return await _cateService.GetAllCategorys();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CategoryDto>> GetSingleCategory(int id)
        {
            var result = await _cateService.GetSingleCategory(id);
            if (result is null)
                return NotFound("Désolé mais cette catégorie n'existe que dans tes rêves :(");
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<List<CategoryDto>>> AddCategory(PostCategory category)
        {
            var result = await _cateService.AddCategory(category);
            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<List<CategoryDto>>> UpdateCategory(int id, PostCategory request)
        {
            var result = await _cateService.UpdateCategory(id, request);
            if (result is null)
                return NotFound("Désolé mais cette catégorie n'existe que dans tes rêves :(");
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<CategoryDto>>> DeleteCategory(int id)
        {
            var result = await _cateService.DeleteCategory(id);
            if (!result)
                return NotFound("Désolé mais cette catégorie n'existe que dans tes rêves :(");
            return Ok(result);
        }
    }
}
