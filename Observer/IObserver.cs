using System;

namespace Observer
{
    public interface IObserver
    {
        Action Update();
    }
}