using System;
using NegoSud.Server.DTO;

namespace NegoSud.Server.Services.CategoryService
{
    public interface ICategoryService // mise en oeuvre des méthodes du user service
    {
        Task<List<CategoryDto>> GetAllCategorys();

        Task<CategoryDto> GetSingleCategory(int id);

        Task<CategoryDto> AddCategory(PostCategory category);

        Task<CategoryDto> UpdateCategory(int id, PostCategory request);

        Task<bool> DeleteCategory(int id);
    }
}