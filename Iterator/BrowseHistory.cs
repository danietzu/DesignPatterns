using System.Collections.Generic;
using System.Linq;

namespace Iterator
{
    public class BrowseHistory<T>
    {
        private readonly List<T> _urls = new List<T>();

        public IIterator<T> CreateIterator()
        {
            return new ListIterator(this);
        }

        public void Push(T url)
        {
            _urls.Add(url);
        }

        public T Pop()
        {
            var lastIndex = _urls.Count() - 1;
            var lastUrl = _urls[lastIndex];
            _urls.RemoveAt(lastIndex);

            return lastUrl;
        }

        public class ListIterator : IIterator<T>
        {
            private readonly BrowseHistory<T> _history;
            private int _index;

            public ListIterator(BrowseHistory<T> history)
            {
                _history = history;
            }

            public T Current()
            {
                return _history._urls[_index];
            }

            public bool HasNext()
            {
                return (_index < _history._urls.Count());
            }

            public void Next()
            {
                _index++;
            }
        }
    }
}