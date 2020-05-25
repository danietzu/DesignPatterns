namespace Mediator.WithoutObserver
{
    public abstract class UIControl
    {
        private DialogBox _owner;

        public UIControl(DialogBox owner)
        {
            _owner = owner;
        }

        public DialogBox Owner
        {
            protected get => _owner;
            set => _owner = value;
        }
    }
}