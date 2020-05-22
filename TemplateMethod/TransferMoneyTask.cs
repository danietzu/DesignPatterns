using System;

namespace TemplateMethod
{
    public class TransferMoneyTask : BaseTask
    {
        protected override void DoExecute()
        {
            Console.WriteLine("Transfer Money");
        }
    }
}