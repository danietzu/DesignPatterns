namespace SOLID.LSP.Example2
{
    public class Employee : BaseEmployee, IManaged
    {
        public IEmployee Manager { get; set; } = null;

        public virtual void AssignManager(IEmployee manager)
        {
            // ... task ...
            Manager = manager;
        }
    }
}