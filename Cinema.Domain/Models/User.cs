using Cinema.Domain.Common;

namespace Cinema.Domain.Models
{
    public class User : Entity
    {
        public Name Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public List<Review> Reviews { get; set; }
        public List<Ticket> PurchasedTicket { get; set; }

        private User(int id, Name name, string email, string password, List<Review> reviews, List<Ticket> purchasedTicket): base(id)
        {
            Name = name;
            Email = email;
            Password = password;
            Reviews = reviews;
            PurchasedTicket = purchasedTicket;
        }
    }
}
