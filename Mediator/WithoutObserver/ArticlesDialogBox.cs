using System;

namespace Mediator.WithoutObserver
{
    public class ArticlesDialogBox : DialogBox
    {
        private readonly ListBox _articlesListsBox;
        private readonly TextBox _titleTextBox;
        private readonly Button _saveButton;

        public ArticlesDialogBox()
        {
            _articlesListsBox = new ListBox(this);
            _titleTextBox = new TextBox(this);
            _saveButton = new Button(this);
        }

        public void SimulateUserInteraction() // for testing
        {
            _articlesListsBox.Selection = "Article 1";
            _titleTextBox.Content = "";
            Console.WriteLine("Text Box: " + _titleTextBox.Content);
            Console.WriteLine("Save Button: " + _saveButton.IsEnabled);
        }

        public override void Changed(UIControl control)
        {
            if (control == _articlesListsBox)
                ArticleSelected();
            else if (control == _titleTextBox)
                TitleChanged();
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