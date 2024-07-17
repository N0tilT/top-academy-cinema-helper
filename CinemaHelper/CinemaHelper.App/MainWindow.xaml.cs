using CinemaHelper.Core.Data;
using CinemaHelper.Core.Service;
using System.Windows;

namespace CinemaHelper.App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainViewModel viewModel = new MainViewModel(new CinemaService(new CinemaDataSource()));
        public MainWindow()
        {
            DataContext = viewModel;
            InitializeComponent();
        }
    }
}