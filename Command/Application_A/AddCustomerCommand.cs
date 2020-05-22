using Command.Framework;

namespace Command.Application_A
{
    public class AddCustomerCommand : ICommand
    {
        private readonly CustomerService _service;

        public AddCustomerCommand(CustomerService service)
        {
            _service = service;
        }

        public void Execute()
        {
            _service.AddCustomer();
        }
    }
}