using System.Collections.Generic;
using SomeApp.Blazor.Services.Interfaces;

namespace SomeApp.Blazor.Services.Implementations
{
		public class CommandManager
		{
				private Stack<ICommand> commands = new Stack<ICommand>();

				public void Invoke(ICommand command)
				{
						if(command.CanExecute())
						{
								commands.Push(command);
								command.Execute();
						}
				}

				public void Undo()
				{
						if(commands.Count > 0)
						{
								ICommand command = commands.Pop();
								command.Undo();
						}
				}
		}
}
