using SomeApp.Blazor.Services.Interfaces;
using SomeApp.Blazor.Services.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace SomeApp.Blazor.Services.Implementations
{
	public sealed class GlobalInfo : IGlobalInfo
	{
		private List<User> _usersOnline;

		public GlobalInfo()
		{
			_usersOnline = new List<User>();
		}

		public async Task<bool> AddUserOnlineAsync(User user)
		{
			bool result = false;

			if(!_usersOnline.Contains(user))
			{
				_usersOnline.Add(user);
				result = true;
			}

			return await Task.FromResult(result);
		}

		public async Task<bool> RemoveUserOnlineAsync(User user)
		{
			bool result = false;
			if (_usersOnline.Contains(user))
			{
				_usersOnline.Remove(user);
				result = true;
			}

			return await Task.FromResult(result);
		}

		public async Task<User> GetLastUserOnlineAsync()
		{
			return await Task.FromResult(_usersOnline.Last());
		}

		public async Task<List<User>> GetAllUsersOnlineAsync()
		{
			return await Task.FromResult(_usersOnline);
		}

		public async Task<int> GetCurrentUserCountAsync()
		{
			return await Task.FromResult(_usersOnline.Count);
		}
	}
}
