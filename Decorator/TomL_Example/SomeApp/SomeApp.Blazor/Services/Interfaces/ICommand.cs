namespace SomeApp.Blazor.Services.Interfaces
{
		public interface ICommand
		{
				void Execute();
				bool CanExecute();
				void Undo();
		}
}
