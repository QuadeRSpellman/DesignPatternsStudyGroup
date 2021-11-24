namespace Bero_CommandPattern.CommandPattern.Commands
{
	public class ItalicsCommand : ICommand
	{
		private string _inputText;
		private string _previousText;

		public ItalicsCommand(string inputText)
		{
			_inputText = inputText;
			_previousText = inputText;
		}

		public string Execute()
		{
			_inputText = $"<i>{_inputText}</i>";
			return _inputText;
		}

		public string Undo()
		{
			_inputText = _previousText;
			return _inputText;
		}
	}
}
