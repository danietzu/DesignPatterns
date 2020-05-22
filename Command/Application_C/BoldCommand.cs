using Command.Application_C.Editor;
using Command.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Command.Application_C
{
    public class BoldCommand : IUndoableCommand
    {
        private string _prevContent;
        private readonly HtmlDocument _document;
        private readonly History _history;

        public BoldCommand(HtmlDocument document, History history)
        {
            _document = document;
            _history = history;
        }

        public void Execute()
        {
            _prevContent = _document.Content;
            _document.MakeBold();
            _history.Push(this);
        }

        public void Unexecute()
        {
            _document.Content = _prevContent;
        }
    }
}