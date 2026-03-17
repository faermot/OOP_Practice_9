using System.Windows;
using System.Windows.Input;

namespace OOP_Practice_9
{
    public partial class MainWindow : Window
    {
        private bool _isMaximized = false;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                DragMove();
        }

        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ClickCount == 2)
            {
                if (_isMaximized)
                {
                    WindowState  = WindowState.Normal;
                    Width        = 1080;
                    Height       = 720;
                    _isMaximized = false;
                }
                else
                {
                    WindowState  = WindowState.Maximized;
                    _isMaximized = true;
                }
            }
        }
    }
}
