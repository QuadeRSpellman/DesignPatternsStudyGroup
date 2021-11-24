namespace Bero_CommandPattern.CommandPattern.Commands
{
	public class BoldCommand : ICommand
	{
		string _inputText;
		string _previousText;
		public BoldCommand(string inputText)
		{
			_inputText = inputText;
			_previousText = inputText;
		}

		public string Execute()
		{
			_inputText = $"<b>{_inputText}</b>";
			return _inputText;
		}

		public string Undo()
		{
			_inputText = _previousText;
			return _inputText;
		}
	}
}
