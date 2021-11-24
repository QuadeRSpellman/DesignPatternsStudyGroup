namespace Bero_CommandPattern.CommandPattern.Commands
{
	public interface ICommand
	{
		string Execute();
		string Undo();
	}
}
