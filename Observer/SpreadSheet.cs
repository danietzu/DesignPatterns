using System;

namespace Observer
{
    public class SpreadSheet : IObserver
    {
        // Pull Style of Communication
        private readonly DataSource _dataSource;

        public SpreadSheet(DataSource dataSource)
        {
            _dataSource = dataSource;
        }

        public void Update()
        {
            Console.WriteLine("Spreadsheet got notified with value: " + _dataSource.Value);
        }
    }
}