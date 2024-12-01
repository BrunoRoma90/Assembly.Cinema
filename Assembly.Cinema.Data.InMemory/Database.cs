using Cinema.Domain.Models;

namespace Assembly.Cinema.Data.InMemory
{
    public class Database
    {
        private static Database _instance;

        public List<User> Users { get; set; }

        private Database() 
        {
            Users = [];
        }

        public static Database Instance => _instance is null
       ? _instance = new Database()
       : _instance;

        public static Database Instance1 => _instance ?? new Database();
    }
}
