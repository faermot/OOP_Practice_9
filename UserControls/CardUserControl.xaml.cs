using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace OOP_Practice_9.UserControls
{
    public partial class CardUserControl : UserControl
    {
        public CardUserControl()
        {
            InitializeComponent();
        }

        public string Title
        {
            get => (string)GetValue(TitleProperty);
            set => SetValue(TitleProperty, value);
        }
        public static readonly DependencyProperty TitleProperty =
            DependencyProperty.Register("Title", typeof(string), typeof(CardUserControl));

        public bool IsChecked
        {
            get => (bool)GetValue(IsCheckedeProperty);
            set => SetValue(IsCheckedeProperty, value);
        }
        public static readonly DependencyProperty IsCheckedeProperty =
            DependencyProperty.Register("IsChecked", typeof(bool), typeof(CardUserControl));

        public bool IsHorizontal
        {
            get => (bool)GetValue(IsHorizontalProperty);
            set => SetValue(IsHorizontalProperty, value);
        }
        public static readonly DependencyProperty IsHorizontalProperty =
            DependencyProperty.Register("IsHorizontal", typeof(bool), typeof(CardUserControl));

        public ImageSource ImageOn
        {
            get => (ImageSource)GetValue(ImageOnProperty);
            set => SetValue(ImageOnProperty, value);
        }
        public static readonly DependencyProperty ImageOnProperty =
            DependencyProperty.Register("ImageOn", typeof(ImageSource), typeof(CardUserControl));

        public ImageSource ImageOff
        {
            get => (ImageSource)GetValue(ImageOffProperty);
            set => SetValue(ImageOffProperty, value);
        }
        public static readonly DependencyProperty ImageOffProperty =
            DependencyProperty.Register("ImageOff", typeof(ImageSource), typeof(CardUserControl));
    }
}
