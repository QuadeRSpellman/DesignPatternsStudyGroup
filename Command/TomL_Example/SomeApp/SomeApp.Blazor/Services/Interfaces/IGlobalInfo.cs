using SomeApp.Blazor.Services.Models;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace SomeApp.Blazor.Services.Interfaces
{
	public interface IGlobalInfo
	{
		Task<bool> AddUserOnlineAsync(User user);
		Task<bool> RemoveUserOnlineAsync(User user);
		Task<User> GetLastUserOnlineAsync();
		Task<List<User>> GetAllUsersOnlineAsync();
		Task<int> GetCurrentUserCountAsync();
	}
}
