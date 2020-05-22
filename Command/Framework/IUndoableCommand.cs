using System;
using System.Collections.Generic;
using System.Text;

namespace Command.Framework
{
    public interface IUndoableCommand : ICommand
    {
        void Unexecute();
    }
}