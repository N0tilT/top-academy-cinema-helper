using CinemaHelper.App.Core;

namespace CinemaHelper.App
{
    public class BookingViewModel : ObservableObject
    {
        private TicketService ticketService;

        public BookingViewModel(TicketService ticketService) 
        {
            this.ticketService = ticketService;
        }
    }
}