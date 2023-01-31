using System;
using Microsoft.EntityFrameworkCore;

namespace NegoSud.Services.CustomerService
{
    public class UserService : IUserService // dossier service sert a stocker les classes responsable de la logique métier tel que gestion user, accés DB (utile de les séparer de celle logique présentation, (interaction avec user tel que MVC))
    {
        private readonly DataContext _context;

        public UserService(DataContext  context)
        {
            _context = context;
        }

        public async Task<List<User>> AddUser(User customer)
        {
            _context.Users.Add(customer);
            await _context.SaveChangesAsync();

            return await _context.Users.ToListAsync();

        }

        public async Task<List<User>?> DeleteUser(int id)
        {
            var user = await _context.Users.FindAsync(id);
            if (user is null)
                return null;

            _context.Users.Remove(user);
            await _context.SaveChangesAsync();

            return await _context.Users.ToListAsync();

        }

        public async Task<List<User>> GetAllUsers()
        {
            var Use = await _context.Users.ToListAsync();
            return Use;
        }

        public async Task<User?> GetSingleUser(int id)
        {
            var user = await _context.Users.FindAsync(id);
            if (user is null)
                return null;

            return user;
        }

        public async Task<List<User>?> UpdateUser(int id, User request)
        {
            var user = await _context.Users.FindAsync(id);
            if (user is null)
                return null;

            user.Name = request.Name;
            user.FirstName = request.FirstName;
            user.ZipCode = request.ZipCode;
            user.City = request.City;
            user.Street = request.Street;
            user.AddressNumber = request.AddressNumber;
            user.Email = request.Email;
            user.PhoneNumber = request.PhoneNumber;

            await _context.SaveChangesAsync();

            return await _context.Users.ToListAsync();
        }
    }
}

