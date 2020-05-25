using System;

namespace Mediator.WithObserver
{
    public class ArticlesDialogBox
    {
        private readonly ListBox _articlesListsBox = new ListBox();
        private readonly TextBox _titleTextBox = new TextBox();
        private readonly Button _saveButton = new Button();

        public ArticlesDialogBox()
        {
            _articlesListsBox.Attach(new Observer());
            //_titleTextBox.Attach();
            //_saveButton.Attach();
        }

        public void SimulateUserInteraction() // for testing
        {
            _articlesListsBox.Selection = "Article 1";
            _titleTextBox.Content = "";
            Console.WriteLine("Text Box: " + _titleTextBox.Content);
            Console.WriteLine("Save Button: " + _saveButton.IsEnabled);
        }

        private void ArticleSelected()
        {
            _titleTextBox.Content = _articlesListsBox.Selection;
            _saveButton.IsEnabled = true;
        }

        private void TitleChanged()
        {
            var content = _titleTextBox.Content;
            var isEmpty = string.IsNullOrWhiteSpace(content);

            _saveButton.IsEnabled = !isEmpty;
        }
    }
}