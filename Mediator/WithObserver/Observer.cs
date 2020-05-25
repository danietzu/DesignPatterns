using System;

namespace Mediator.WithObserver
{
    public class Observer : IObserver
    {
        public Observer()
        {
            //Update = () => UpdateImpl();
        }

        public void Update()
        {
        }

        public virtual Action UpdateImpl() => null;
    }
}