using System;
using Microsoft.EntityFrameworkCore;
using NegoSud.Server.DTO;

namespace NegoSud.Server.Services.CategoryService
{
    public class CategoryService : ICategoryService // dossier service sert a stocker les classes responsable de la logique métier tel que gestion supplier, accés DB (utile de les séparer de celle logique présentation, (interaction avec user tel que MVC))
    {
        private readonly DataContext _context;

        public CategoryService(DataContext context)
        {
            _context = context;
        }



        public async Task<CategoryDto> AddCategory(PostCategory request)
        {
            var category = new Category();

            category.Name = request.Name;
            category.Description = request.Description;

            _context.Categorys.Add(category);
            await _context.SaveChangesAsync();

            return new CategoryDto { Name = category.Name, Description = category.Description };

        }

        public async Task<bool> DeleteCategory(int id)
        {
            var category = await _context.Categorys.FindAsync(id);
            if (category is null)
                return false;

            _context.Categorys.Remove(category);
            await _context.SaveChangesAsync();

            return true;

        }

        public async Task<List<CategoryDto>> GetAllCategorys()
        {
            var category = await _context.Categorys.ToListAsync();
            var listCategoryDto = new List<CategoryDto>();
            foreach (var item in category)
            {
                var categorydto = new CategoryDto { Id = item.Id };
                listCategoryDto.Add(categorydto);
            }
            return listCategoryDto;
        }

        public async Task<CategoryDto> GetSingleCategory(int id)
        {
            var category = await _context.Categorys.FindAsync(id);
            if (category is null)
                return null;
            var categorydto = new CategoryDto { Name = category.Name, Description = category.Description };

            return categorydto;
        }

        public async Task<CategoryDto> UpdateCategory(int id, PostCategory request)
        {
            var category = await _context.Categorys.FindAsync(id);
            if (category is null)
                return null;

            category.Name = request.Name;
            category.Description = request.Description;

            await _context.SaveChangesAsync();
            var categorydto = new CategoryDto { Name = category.Name, Description = category.Description };

            return categorydto;
        }
    }
}

