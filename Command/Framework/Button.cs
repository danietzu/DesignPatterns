namespace Command.Framework
{
    public class Button
    {
        private string _label;
        private readonly ICommand _command;

        public Button(ICommand command)
        {
            _command = command;
        }

        public string Label { get => _label; set => _label = value; }

        public void Click()
        {
            _command.Execute();
        }
    }
}