using Command.Application_A;
using Command.Application_B;
using Command.Application_C;
using Command.Application_C.Editor;
using Command.Framework;

namespace Command
{
    internal class Program
    {
        private static void Main()
        {
            // Application_A
            var service = new CustomerService();
            var command = new AddCustomerCommand(service);
            var button = new Button(command);

            button.Click();

            // Application_B
            var composite = new CompositeCommand();
            composite.Add(new ResizeCommand());
            composite.Add(new BlackAndWhiteCommand());

            composite.Execute();

            // Application_C
            var history = new History();
            var document = new HtmlDocument
            {
                Content = "Hello World"
            };

            var boldCommand = new BoldCommand(document, history);

            boldCommand.Execute();
            System.Console.WriteLine(document.Content); // <b>Hello World</b>

            var undoCommand = new UndoCommand(history);
            undoCommand.Execute();
            System.Console.WriteLine(document.Content); // Hello World
        }
    }
}