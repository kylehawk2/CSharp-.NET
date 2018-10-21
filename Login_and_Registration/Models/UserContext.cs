using Microsoft.EntityFrameworkCore;

namespace Login_and_Registration.Models
{
    public class UserContext : DbContext
    {
        public UserContext (DbContextOptions<UserContext> options) : base(options) { }
        public DbSet<User> users {get;set;}
    }
}