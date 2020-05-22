using System;
using System.Collections.Generic;
using System.Text;

namespace Memento
{
    public class EditorState
    {
        private readonly string _content;

        public EditorState(string content)
        {
            _content = content;
        }

        public string Content { get => _content; }
    }
}