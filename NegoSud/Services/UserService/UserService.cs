using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using NegoSud.Server.DTO;
using NegoSud.Server.Models;

namespace NegoSud.Server.Services.UserService
{
    public class UserService : IUserService // dossier service sert a stocker les classes responsable de la logique métier tel que gestion user, accés DB (utile de les séparer de celle logique présentation, (interaction avec user tel que MVC))
    {
        private readonly DataContext _context;

        public UserService(DataContext  context)
        {
            _context = context;
        }

        public async Task<UserDto> AddUser(PostUser request)
        {
            var user = new User();

            user.Login = request.Login;
            user.Password = request.Password;
            user.LastName = request.LastName;
            user.FirstName = request.FirstName;
            user.LastName = request.LastName;
            user.Email = request.Email;
            user.Phone = request.Phone;
            user.City = request.City;
            user.ZipCode = request.ZipCode;
            user.Street = request.Street;
            user.Role = request.Role;

            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            return new UserDto {
                Id = user.Id,
                Login = user.Login,
                Password = user.Password,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                Phone = user.Phone,
                City = user.City,
                ZipCode = user.ZipCode,
                Street = user.Street,
                Role = user.Role, };

        }

        public async Task<bool> DeleteUser(int id)
        {
            var user = await _context.Users.FindAsync(id);
            if (user is null)
                return false;

            _context.Users.Remove(user);
            await _context.SaveChangesAsync();

            return true;

        }

        public async Task<List<UserDto>> GetAllUsers()
        {
            var user = await _context.Users.ToListAsync();
            var listuserdto = new List<UserDto>();
            foreach (var item in user)
            {
                var userdto = new UserDto {
                    Id = item.Id,
                    Login = item.Login,
                    Password = item.Password,
                    FirstName = item.FirstName,
                    LastName = item.LastName,
                    Email = item.Email,
                    Phone = item.Phone,
                    City = item.City,
                    ZipCode = item.ZipCode,
                    Street = item.Street,
                    Role = item.Role,
                };
                listuserdto.Add(userdto);
            }
            return listuserdto;
        }

        public async Task<UserDto> GetSingleUser(int id)
        {
            var user = await _context.Users.FindAsync(id);
            if (user is null)
                return null;

            var userdto = new UserDto
            {
                Id = user.Id,
                Login = user.Login,
                Password = user.Password,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                Phone = user.Phone,
                City = user.City,
                ZipCode = user.ZipCode,
                Street = user.Street,
                Role = user.Role,
            };

            return userdto;
        }

        public async Task<UserDto> UpdateUser(int id, PostUser request)
        {
            var user = await _context.Users.FindAsync(id);
            if (user is null)
                return null;

            if (request.Login != string.Empty)
                user.Login = request.Login;
            if (request.Password != string.Empty)
                user.Password = request.Password;
            if (request.FirstName != string.Empty)
                user.FirstName = request.FirstName;
            if (request.LastName != string.Empty)
                user.LastName = request.LastName;
            if (request.Email != string.Empty)
                user.Email = request.Email;
            if (request.Phone != string.Empty)
                user.Phone = request.Phone;
            if (request.City != string.Empty)
                user.City = request.City;
            if (request.ZipCode != string.Empty)
                user.ZipCode = request.ZipCode;
            if (request.Street != string.Empty)
                user.Street = request.Street;
            if (request.Role != string.Empty)
                user.Role = request.Role;

            await _context.SaveChangesAsync();
            var userdto = new UserDto
            {
                Id = user.Id,
                Login = user.Login,
                Password = user.Password,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                Phone = user.Phone,
                City = user.City,
                ZipCode = user.ZipCode,
                Street = user.Street,
                Role = user.Role,
            };

            return userdto;
        }
    }
}

