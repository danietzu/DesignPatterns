using System;

namespace Observer
{
    public class Chart : IObserver
    {
        // Pull Style of Communication
        private readonly DataSource _dataSource;

        public Chart(DataSource dataSource)
        {
            _dataSource = dataSource;
        }

        public void Update()
        {
            Console.WriteLine("Chart got updated with value: " + _dataSource.Value);
        }
    }
}