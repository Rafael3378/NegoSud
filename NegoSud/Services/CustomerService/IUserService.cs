using System;
namespace NegoSud.Services.CustomerService
{
	public interface ICustomerService // mise en oeuvre des méthodes du customer service
	{
		Task<List<User>> GetAllCustomers();

		Task<User?> GetSingleCustomer(int id);

		Task<List<User>> AddCustomer(User customer);

		Task<List<User>?> UpdateCustomer(int id, User request);

        Task<List<User>?> DeleteCustomer(int id);
	}
}

