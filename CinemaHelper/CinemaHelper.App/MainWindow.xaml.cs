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
        private MainViewModel cinemaListViewModel = new MainViewModel(new CinemaService(new CinemaDataSource()));
        private BookingViewModel bokingViewModel = new BookingViewModel(new TicketService(new TicketDataSource()));


        public MainWindow()
        {
            InitializeComponent();
        }

        private void BokingPage_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new BookingPage(bokingViewModel);
        }

        private void CinemaListPage_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new CinemaListPage(cinemaListViewModel);
        }
    }
}