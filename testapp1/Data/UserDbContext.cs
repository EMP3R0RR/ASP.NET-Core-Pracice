using Microsoft.EntityFrameworkCore;
using testapp1.Models;
namespace testapp1.Data


{
    public class UserDbContext : DbContext
    {

        // Constructor to pass options to the base DbContext class 
        public UserDbContext(DbContextOptions<UserDbContext> options)
            : base(options)
        {
        }

        // DbSet representing the Users table in the database
        public DbSet<User> Users { get; set; }
    }
}






