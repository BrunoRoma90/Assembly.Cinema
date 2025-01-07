using Cinema.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assembly.Cinema.Services.Interfaces
{
    public interface IUserServices
    {
        List<User> GetAll();

        User Add(User user);
    }
}
