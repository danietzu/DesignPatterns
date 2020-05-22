using System;

namespace TemplateMethod
{
    public class GenerateReportTask : BaseTask
    {
        protected override void DoExecute()
        {
            Console.WriteLine("Generate Report");
        }
    }
}