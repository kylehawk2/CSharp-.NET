using Microsoft.EntityFrameworkCore;
 
namespace Entity_Practice.Models
{
    public class EntityContext : DbContext
    {
        // base() calls the parent class' constructor passing the "options" parameter along
        public EntityContext(DbContextOptions<EntityContext> options) : base(options) { }

        public DbSet<Person> Users {get;set;}
    }
}
