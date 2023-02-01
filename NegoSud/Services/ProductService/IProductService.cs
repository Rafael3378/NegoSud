using System;
using NegoSud.Server.DTO;

namespace NegoSud.Server.Services.ProductService
{
    public interface IProductService // mise en oeuvre des méthodes du customer service
    {
        Task<List<ProductDto>> GetAllProducts();

        Task<ProductDto> GetSingleProduct(int id);

        Task<ProductDto> AddProduct(PostProduct product);

        Task<ProductDto> UpdateProduct(int id, PostProduct request);

        Task<bool> DeleteProduct(int id);
    }
}

