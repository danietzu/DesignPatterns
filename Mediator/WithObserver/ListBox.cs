namespace Mediator.WithObserver
{
    public class ListBox : UIControl
    {
        private string _selection;

        public string Selection
        {
            get => _selection;
            set
            {
                _selection = value;
                NotifyObservers();
            }
        }
    }
}