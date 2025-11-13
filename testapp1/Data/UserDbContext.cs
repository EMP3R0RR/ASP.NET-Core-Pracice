using Microsoft.EntityFrameworkCore;
using testapp1.Models;
namespace testapp1.Data


{
    public class UserDbContext : DbContext
    {

        public UserDbContext(DbContextOptions<UserDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
    }
}
