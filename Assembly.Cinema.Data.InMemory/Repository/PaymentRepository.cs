using Cinema.Domain.Models;

public class PaymentRepository : Repository<Payment, int>, IPaymentRepository
{
    public override void Add(Payment obj)
    {
        throw new NotImplementedException();
    }

    public override void Delete(Payment obj)
    {
        throw new NotImplementedException();
    }

    public override List<Payment> GetAll()
    {
        throw new NotImplementedException();
    }

    public override Payment GetById(int id)
    {
        throw new NotImplementedException();
    }

    public override void Update(Payment obj)
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



}
