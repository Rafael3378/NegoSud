﻿using System;
using Microsoft.EntityFrameworkCore;
using NegoSud.Server.DTO;

namespace NegoSud.Server.Services.ProductService
{
    public class ProductService : IProductService // dossier service sert a stocker les classes responsable de la logique métier tel que gestion supplier, accés DB (utile de les séparer de celle logique présentation, (interaction avec user tel que MVC))
    {
        private readonly DataContext _context;

        public ProductService(DataContext context)
        {
            _context = context;
        }

        public async Task<ProductDto> AddProduct(PostProduct request)
        {
            var product = new Product();
           
            product.Name = request.Name;
            product.Ref = request.Ref;
            product.UnitPrice = request.UnitPrice;
            product.PackPrice = request.PackPrice;
            product.CreationDate = request.CreationDate;
            product.UpdateDate = request.UpdateDate;
            product.Millesime = request.Millesime;
            product.Stock = request.Stock;
            product.StockTreshold = request.StockTreshold;
            product.CategoryId = request.CategoryId;
            product.SupplierId = request.SupplierId;

            _context.Products.Add(product);
            await _context.SaveChangesAsync();

            return new ProductDto {
                Id = product.Id,
                Name = product.Name,
                Ref = product.Ref,
                UnitPrice = product.UnitPrice,
                PackPrice = product.PackPrice,
                CreationDate = product.CreationDate,
                UpdateDate = product.UpdateDate,
                Millesime = product.Millesime,
                Stock = product.Stock,
                StockTreshold = product.StockTreshold,
                CategoryId = product.CategoryId,
                SupplierId = product.SupplierId };

        }

        public async Task<bool> DeleteProduct(int id)
        {
            var product = await _context.Products.FindAsync(id);
            if (product is null)
                return false;

            _context.Products.Remove(product);
            await _context.SaveChangesAsync();

            return true;

        }

        public async Task<List<ProductDto>> GetAllProducts()
        {
            var product = await _context.Products.ToListAsync();
            var listProductDto = new List<ProductDto>();
            foreach (var item in product)
            {
                var productdto = new ProductDto { Id = item.Id};
                listProductDto.Add(productdto);
            }
            return listProductDto;
        }

        public async Task<ProductDto> GetSingleProduct(int id)
        {
            var product = await _context.Products.FindAsync(id);
            if (product is null)
                return null;
            var productdto = new ProductDto {
                Id = product.Id,
                Name = product.Name,
                Ref = product.Ref,
                UnitPrice = product.UnitPrice,
                PackPrice = product.PackPrice,
                CreationDate = product.CreationDate,
                UpdateDate = product.UpdateDate,
                Millesime = product.Millesime,
                Stock = product.Stock,
                StockTreshold = product.StockTreshold,
                CategoryId = product.CategoryId,
                SupplierId = product.SupplierId
            };
            return productdto;
        }

        public async Task<ProductDto> UpdateProduct(int id, PostProduct request)
        {
            var product = await _context.Products.FindAsync(id);
            if (product is null)
                return null;

            product.Name = request.Name;
            product.Ref = request.Ref;
            product.UnitPrice = request.UnitPrice;
            product.PackPrice = request.PackPrice;
            product.CreationDate = request.CreationDate;
            product.UpdateDate = request.UpdateDate;
            product.Millesime = request.Millesime;
            product.Stock = request.Stock;
            product.StockTreshold = request.StockTreshold;
            product.CategoryId = request.CategoryId;
            product.SupplierId = request.SupplierId;

            await _context.SaveChangesAsync();
            var productdto = new ProductDto
            {
                Id = product.Id,
                Name = product.Name,
                Ref = product.Ref,
                UnitPrice = product.UnitPrice,
                PackPrice = product.PackPrice,
                CreationDate = product.CreationDate,
                UpdateDate = product.UpdateDate,
                Millesime = product.Millesime,
                Stock = product.Stock,
                StockTreshold = product.StockTreshold,
                CategoryId = product.CategoryId,
                SupplierId = product.SupplierId };

            return productdto;
        }
    }
}

