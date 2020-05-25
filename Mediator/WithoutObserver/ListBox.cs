namespace Mediator.WithoutObserver
{
    public class ListBox : UIControl
    {
        private string _selection;

        public ListBox(DialogBox owner) : base(owner)
        {
        }

        public string Selection
        {
            get => _selection;
            set
            {
                _selection = value;
                Owner.Changed(this);
            }
        }
    }
}