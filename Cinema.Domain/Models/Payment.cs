using Cinema.Domain.Common;

namespace Cinema.Domain.Models;

public class Payment : AuditableEntity<int>
{
    public User User { get; set; }
    public Ticket Ticket { get; set; }
    public string PaymentMethod { get; set; }

    public DateTime PaymentDate { get; set; }

    public bool IsSuccessful { get; set; }


    private Payment(User user, Ticket ticket, string paymentMethod, DateTime paymentDate, bool isSuccessful)
    {
        User = user;
        Ticket = ticket;
        PaymentMethod = paymentMethod;
        PaymentDate = paymentDate;
        IsSuccessful = isSuccessful;
    }
}
