using Assembly.Cinema.Domain.Core.Repositories;
using Cinema.Domain.Models;

public interface IPaymentRepository : IRepository<Payment, int>
{
    public Payment GetPaymentByUser(User user);
    public List<Payment> GetPaymentByPaymentDate(Payment paymentDate);
}
