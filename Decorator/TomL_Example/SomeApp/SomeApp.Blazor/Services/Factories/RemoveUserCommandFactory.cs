using SomeApp.Blazor.Services.Implementations;
using SomeApp.Blazor.Services.Interfaces;

namespace SomeApp.Blazor.Services.Factories
{
		public class RemoveUserCommandFactory : CommandFactory
		{
				public override ICommand CreateCommand(IGlobalInfo globalInfo, Models.User user)
				{
						RemoveUserCommand command = new RemoveUserCommand(globalInfo, user);

						return command;
				}
		}
}
