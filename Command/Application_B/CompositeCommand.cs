using Command.Framework;
using System.Collections.Generic;

namespace Command.Application_B
{
    public class CompositeCommand : ICommand
    {
        private readonly IList<ICommand> _commands = new List<ICommand>();

        public void Add(ICommand command)
        {
            _commands.Add(command);
        }

        public void Execute()
        {
            foreach (var command in _commands)
                command.Execute();
        }
    }
}