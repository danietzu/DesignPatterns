namespace Mediator.WithObserver
{
    public class TextBox : UIControl
    {
        private string _content;

        public string Content
        {
            get => _content;
            set
            {
                _content = value;
                NotifyObservers();
            }
        }
    }
}