using System;
using Stylet;

namespace SampleApp.Pages
{
    public class ShellViewModel : Screen
    {
        private string _columnDefinitions;

        public string ColumnDefinitions
        {
            get => _columnDefinitions;
            set => SetAndNotify(ref _columnDefinitions, value);
        }
    }
}
