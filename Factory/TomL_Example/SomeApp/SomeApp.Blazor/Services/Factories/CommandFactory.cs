using SomeApp.Blazor.Services.Interfaces;

namespace SomeApp.Blazor.Services.Factories
{
		public abstract class CommandFactory
		{
				public abstract ICommand CreateCommand(IGlobalInfo globalInfo, Models.User user);

				public ICommand GetCommand(IGlobalInfo globalInfo, Models.User user)
				{
						ICommand command = CreateCommand(globalInfo, user);

						return command;
				}
		}
}
