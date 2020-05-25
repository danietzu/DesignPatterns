using System.Collections.Generic;

namespace Mediator.WithObserver
{
    public abstract class UIControl
    {
        private readonly List<IObserver> _observers = new List<IObserver>();

        public void Attach(IObserver observer)
        {
            _observers.Add(observer);
        }

        protected void NotifyObservers()
        {
            foreach (var observer in _observers)
                observer.Update();
        }
    }
}