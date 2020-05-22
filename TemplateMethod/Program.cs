namespace TemplateMethod
{
    internal class Program
    {
        private static void Main()
        {
            var transfer = new TransferMoneyTask();
            var report = new GenerateReportTask();

            transfer.Execute();
            report.Execute();
        }
    }
}