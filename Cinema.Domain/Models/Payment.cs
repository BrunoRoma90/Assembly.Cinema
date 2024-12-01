using Cinema.Domain.Common;

namespace Cinema.Domain.Models
{
    public class Payment : Entity
    {
        public User User { get; set; }
        public Ticket Ticket { get; set; }
        public string PaymentMethod { get; set; }

        public DateTime PaymentDate { get; set; }

        public bool IsSuccessful { get; set; }


        private Payment(int id, User user, Ticket ticket, string paymentMethod, DateTime paymentDate, bool isSuccessful):
            base(id)
        {
            User = user;
            Ticket = ticket;
            PaymentMethod = paymentMethod;
            PaymentDate = paymentDate;
            IsSuccessful = isSuccessful;
        }
    }
}
