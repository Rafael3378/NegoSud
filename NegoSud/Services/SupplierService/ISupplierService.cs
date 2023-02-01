using System;
using NegoSud.Server.DTO;

namespace NegoSud.Server.Services.SupplierService
{
    public interface ISupplierService // mise en oeuvre des méthodes du customer service
    {
        Task<List<SupplierDto>> GetAllSuppliers();

        Task<SupplierDto> GetSingleSupplier(int id);

        Task<SupplierDto> AddSupplier(PostSupplier supplier);

        Task<SupplierDto> UpdateSupplier(int id, PostSupplier request);

        Task<bool> DeleteSupplier(int id);
    }
}