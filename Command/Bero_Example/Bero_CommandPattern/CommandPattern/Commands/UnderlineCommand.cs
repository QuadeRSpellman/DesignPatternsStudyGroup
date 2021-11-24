namespace Bero_CommandPattern.CommandPattern.Commands
{
	public class UnderlineCommand : ICommand
	{
		private string _inputText;
		private string _previousText;

		public UnderlineCommand(string inputText)
		{
			_inputText = inputText;
			_previousText = inputText;
		}

		public string Execute()
		{
			_inputText = $"<u>{_inputText}</u>";
			return _inputText;
		}

		public string Undo()
		{
			_inputText = _previousText;
			return _inputText;
		}
	}
}
