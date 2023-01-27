using System;
using Microsoft.EntityFrameworkCore;

namespace NegoSud.Services.CustomerService
{
    public class CustomerService : ICustomerService // dossier service sert a stocker les classes responsable de la logique métier tel que gestion user, accés DB (utile de les séparer de celle logique présentation, (interaction avec user tel que MVC))
    {
        private readonly DataContext _context;

        public CustomerService(DataContext  context)
        {
            _context = context;
        }

        public async Task<List<Customer>> AddCustomer(Customer customer)
        {
            _context.Customers.Add(customer);
            await _context.SaveChangesAsync();

            return await _context.Customers.ToListAsync();

        }

        public async Task<List<Customer>?> DeleteCustomer(int id)
        {
            var customer = await _context.Customers.FindAsync(id);
            if (customer is null)
                return null;

            _context.Customers.Remove(customer);
            await _context.SaveChangesAsync();

            return await _context.Customers.ToListAsync();

        }

        public async Task<List<Customer>> GetAllCustomers()
        {
            var custome = await _context.Customers.ToListAsync();
            return custome;
        }

        public async Task<Customer?> GetSingleCustomer(int id)
        {
            var customer = await _context.Customers.FindAsync(id);
            if (customer is null) //retourne un message si le client existe pas
                return null;

            return customer;
        }

        public async Task<List<Customer>?> UpdateCustomer(int id, Customer request)
        {
            var customer = await _context.Customers.FindAsync(id);
            if (customer is null)
                return null;

            customer.Name = request.Name;
            customer.FirstName = request.FirstName;
            customer.ZipCode = request.ZipCode;
            customer.City = request.City;
            customer.Street = request.Street;
            customer.AddressNumber = request.AddressNumber;
            customer.Email = request.Email;
            customer.PhoneNumber = request.PhoneNumber;

            await _context.SaveChangesAsync();

            return await _context.Customers.ToListAsync();
        }
    }
}

