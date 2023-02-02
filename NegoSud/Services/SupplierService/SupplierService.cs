using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using NegoSud.Server.DTO;
using NegoSud.Server.Models;

namespace NegoSud.Server.Services.SupplierService
{
    public class SupplierService : ISupplierService // dossier service sert a stocker les classes responsable de la logique métier tel que gestion supplier, accés DB (utile de les séparer de celle logique présentation, (interaction avec user tel que MVC))
    {
        private readonly DataContext _context;

        public SupplierService(DataContext context)
        {
            _context = context;
        }

        public async Task<SupplierDto> AddSupplier(PostSupplier request)
        {
            var supplier = new Supplier();

            supplier.Name = request.Name;
            supplier.Siret = request.Siret;
            supplier.Email = request.Email;
            supplier.Phone = request.Phone;
            supplier.City = request.City;
            supplier.ZipCode = request.ZipCode;
            supplier.Street = request.Street;

            _context.Suppliers.Add(supplier);
            await _context.SaveChangesAsync();

            return new SupplierDto
            {
                Id = supplier.Id,
                Name = supplier.Name,
                Siret = supplier.Siret,
                Email = supplier.Email,
                Phone = supplier.Phone,
                City = supplier.City,
                ZipCode = supplier.ZipCode,
                Street = supplier.Street,
            };

        }

        public async Task<bool> DeleteSupplier(int id)
        {
            var supplier = await _context.Suppliers.FindAsync(id);
            if (supplier is null)
                return false;

            _context.Suppliers.Remove(supplier);
            await _context.SaveChangesAsync();

            return true;

        }

        public async Task<List<SupplierDto>> GetAllSuppliers()
        {
            var supplier = await _context.Suppliers.ToListAsync();
            var listsupplierdto = new List<SupplierDto>();
            foreach (var item in supplier)
            {
                var supplierdto = new SupplierDto {
                    Id = item.Id,
                    Name = item.Name,
                    Siret = item.Siret,
                    Email = item.Email,
                    Phone = item.Phone,
                    City = item.City,
                    ZipCode = item.ZipCode,
                    Street = item.Street,
                };
                listsupplierdto.Add(supplierdto);
            }
            return listsupplierdto;
        }

        public async Task<SupplierDto> GetSingleSupplier(int id)
        {
            var supplier = await _context.Suppliers.FindAsync(id);
            if (supplier is null)
                return null;

            var supplierdto = new SupplierDto
            {
                Id = supplier.Id,
                Name = supplier.Name,
                Siret = supplier.Siret,
                Email = supplier.Email,
                Phone = supplier.Phone,
                City = supplier.City,
                ZipCode = supplier.ZipCode,
                Street = supplier.Street,
            };

            return supplierdto;
        }

        public async Task<SupplierDto> UpdateSupplier(int id, PostSupplier request)
        {
            var supplier = await _context.Suppliers.FindAsync(id);
            if (supplier is null)
                return null;

            if (request.Name != string.Empty)
                supplier.Name = request.Name;
            if (request.Siret != string.Empty)
                supplier.Siret = request.Siret;
            if (request.Email != string.Empty)
                supplier.Email = request.Email;
            if (request.Phone != string.Empty)
                supplier.Phone = request.Phone;
            if (request.City != string.Empty)
                supplier.City = request.City;
            if (request.ZipCode != string.Empty)
                supplier.ZipCode = request.ZipCode;
            if (request.Street != string.Empty)
                supplier.Street = request.Street;

            await _context.SaveChangesAsync();
            var supplierdto = new SupplierDto
            {
                Id = supplier.Id,
                Name = supplier.Name,
                Siret = supplier.Siret,
                Email = supplier.Email,
                Phone = supplier.Phone,
                City = supplier.City,
                ZipCode = supplier.ZipCode,
                Street = supplier.Street,
            };

            return supplierdto;
        }
    }
}

