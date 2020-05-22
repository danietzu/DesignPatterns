using Command.Framework;
using System.Collections.Generic;

namespace Command.Application_C
{
    public class History
    {
        private readonly Stack<IUndoableCommand> _commands = new Stack<IUndoableCommand>();

        public void Push(IUndoableCommand command)
        {
            _commands.Push(command);
        }

        public IUndoableCommand Pop()
        {
            return _commands.Pop();
        }

        public int Size()
        {
            return _commands.Count;
        }
    }
}