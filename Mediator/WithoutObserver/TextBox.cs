namespace Mediator.WithoutObserver
{
    public class TextBox : UIControl
    {
        private string _content;

        public TextBox(DialogBox owner) : base(owner)
        {
        }

        public string Content
        {
            get => _content;
            set
            {
                _content = value;
                Owner.Changed(this);
            }
        }
    }
}