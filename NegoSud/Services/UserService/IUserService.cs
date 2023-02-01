using System;
using NegoSud.Server.DTO;

namespace NegoSud.Server.Services.UserService
{
	public interface IUserService // mise en oeuvre des méthodes du user service
	{
        Task<List<UserDto>> GetAllUsers();

        Task<UserDto> GetSingleUser(int id);

        Task<UserDto> AddUser(PostUser user);

        Task<UserDto> UpdateUser(int id, PostUser request);

        Task<bool> DeleteUser(int id);
    }
}

