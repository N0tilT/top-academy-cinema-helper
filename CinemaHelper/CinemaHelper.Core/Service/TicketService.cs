namespace CinemaHelper.App
{
    public class TicketService
    {
        private TicketDataSource ticketDataSource;

        public TicketService(TicketDataSource ticketDataSource)
        {
            this.ticketDataSource = ticketDataSource;
        }
    }
}