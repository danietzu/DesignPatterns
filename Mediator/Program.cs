using Mediator.WithoutObserver;
using System;

namespace Mediator
{
    public class Program
    {
        public static void Main()
        {
            // without observer
            var dialog = new ArticlesDialogBox();
            dialog.SimulateUserInteraction();

            // with observer
        }
    }
}