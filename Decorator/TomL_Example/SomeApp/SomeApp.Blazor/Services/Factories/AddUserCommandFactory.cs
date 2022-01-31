using SomeApp.Blazor.Services.Implementations;
using SomeApp.Blazor.Services.Interfaces;

namespace SomeApp.Blazor.Services.Factories
{
		public class AddUserCommandFactory : CommandFactory
		{
				public override ICommand CreateCommand(IGlobalInfo globalInfo, Models.User user)
				{
						AddUserCommand command = new AddUserCommand(globalInfo, user);

						return command;
				}
		}
}
