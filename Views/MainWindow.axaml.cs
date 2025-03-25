using Avalonia.Controls;
using Xoul_s_Era.ViewModels;

namespace Xoul_s_Era.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainWindowViewModel();
        }
    }
}
