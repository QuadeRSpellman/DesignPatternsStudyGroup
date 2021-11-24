using Bero_CommandPattern.CommandPattern.Commands;
using System.Collections;

namespace Bero_CommandPattern.CommandPattern
{
	public class CommandManager
	{
		private Stack commandStack = new Stack();

		public string ExecuteCommand(ICommand command)
		{
			var result = command.Execute();
			commandStack.Push(command);
			return result;
		}

		public string UndoCommand()
		{
			if (commandStack.Count > 0)
			{
				ICommand cmd = (ICommand)commandStack.Pop();
				return cmd.Undo();
			}
			return null;
		}
	}
}
