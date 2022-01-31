using SomeApp.Blazor.Services.Interfaces;
using SomeApp.Blazor.Services.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SomeApp.Blazor.Services.Decorator
{
		public class GlobalInfoLoggingDecorator : IGlobalInfo
		{
				private IGlobalInfo _globalInfo;

				public GlobalInfoLoggingDecorator(IGlobalInfo globalInfo)
				{
						_globalInfo = globalInfo;
				}

				public async Task<bool> AddUserOnlineAsync(User user)
				{
						System.Console.WriteLine($"AddUserOnlineAsync, {user.ToString()}");
						var result = await _globalInfo.AddUserOnlineAsync(user);

						return result;
				}

				public async Task<List<User>> GetAllUsersOnlineAsync()
				{
						System.Console.WriteLine($"GetAllUsersOnlineAsync");
						var result = await _globalInfo.GetAllUsersOnlineAsync();

						return result;
				}

				public async Task<int> GetCurrentUserCountAsync()
				{
						System.Console.WriteLine($"GetCurrentUserCountAsync");
						var result = await _globalInfo.GetCurrentUserCountAsync();

						return result;
				}

				public async Task<User> GetLastUserOnlineAsync()
				{
						System.Console.WriteLine($"GetLastUserOnlineAsync");
						var result = await _globalInfo.GetLastUserOnlineAsync();

						return result;
				}

				public async Task<bool> RemoveUserOnlineAsync(User user)
				{
						System.Console.WriteLine($"RemoveUserOnlineAsync, {user.ToString()}");
						var result = await _globalInfo.RemoveUserOnlineAsync(user);

						return result;
				}
		}
}
