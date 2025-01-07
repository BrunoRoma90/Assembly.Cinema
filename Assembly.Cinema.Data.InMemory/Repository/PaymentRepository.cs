using Cinema.Domain.Models;
using Assembly.Cinema.Domain.Core.Repositories;

namespace Assembly.Cinema.Data.InMemory.Repository;

public class PaymentRepository : IPaymentRepository
{
    public Payment Add(Payment obj)
    {
        throw new NotImplementedException();
    }

    public Payment Delete(Payment id)
    {
        throw new NotImplementedException();
    }

    public List<Payment> GetAll()
    {
        throw new NotImplementedException();
    }

    public Payment GetById(int id)
    {
        throw new NotImplementedException();
    }

    public List<Payment> GetPaymentByPaymentDate(Payment paymentDate)
    {
        throw new NotImplementedException();
    }

    public Payment GetPaymentByUser(User user)
    {
        throw new NotImplementedException();
    }

    public Payment Update(Payment obj)
    {
        throw new NotImplementedException();
    }
}
