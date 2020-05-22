namespace TemplateMethod
{
    public abstract class BaseTask
    {
        private readonly AuditTrail _auditTrail;

        public BaseTask()
        {
            _auditTrail = new AuditTrail();
        }

        public BaseTask(AuditTrail auditTrail)
        {
            _auditTrail = auditTrail;
        }

        public void Execute()
        {
            _auditTrail.Record();

            DoExecute();
        }

        protected abstract void DoExecute();
    }
}