namespace CinemaHelper.App
{
    public class BookingViewModel
    {
        private TicketService ticketService;

        public BookingViewModel(TicketService ticketService)
        {
            this.ticketService = ticketService;
        }
    }
}