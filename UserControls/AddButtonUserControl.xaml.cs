using System.Windows;
using System.Windows.Controls;

namespace OOP_Practice_9.UserControls
{
    public partial class AddButtonUserControl : UserControl
    {
        public AddButtonUserControl()
        {
            InitializeComponent();
        }

        public string Title
        {
            get => (string)GetValue(TitleProperty);
            set => SetValue(TitleProperty, value);
        }

        public static readonly DependencyProperty TitleProperty =
            DependencyProperty.Register("Title", typeof(string), typeof(AddButtonUserControl));
    }
}
