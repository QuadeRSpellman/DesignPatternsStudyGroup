using System.Linq;
using SomeApp.Blazor.Services.Interfaces;
using SomeApp.Blazor.Services.Models;

namespace SomeApp.Blazor.Services.Implementations
{
		public class RemoveUserCommand : ICommand
		{
				private readonly IGlobalInfo _globalInfo;
				private readonly User _user;

				public RemoveUserCommand(IGlobalInfo globalInfo, User user)
				{
						_globalInfo = globalInfo;
						_user = user;
				}

				public bool CanExecute()
				{
						return _user != null && _globalInfo.GetAllUsersOnlineAsync().Result.Any();
				}

				public void Execute()
				{
						_globalInfo.RemoveUserOnlineAsync(_user).Wait(); 
				}

				public void Undo()
				{
						_globalInfo.AddUserOnlineAsync(_user).Wait();
				}
		}
}
