using System;
using System.Collections.Generic;
using System.IO;

namespace SOLID.SRP
{
    public class Journal
    {
        private readonly List<string> _entries = new List<string>();
        private static int _count = 0;

        public int AddEntry(string text)
        {
            _entries.Add($"{++_count}: {text}");
            return _count; // memento
        }

        public void RemoveEntry(int index)
        {
            _entries.RemoveAt(index);
            _count--;
        }

        public override string ToString()
        {
            return string.Join(Environment.NewLine, _entries);
        }

        public void Save(string fileName)
        {
            File.WriteAllText(fileName, this.ToString());
        }

        //public void SaveToFile(string fileName, bool overwrite = false)
        //{
        //    if (overwrite || !File.Exists(fileName))
        //        File.WriteAllText(fileName, this.ToString());
        //}
    }
}