using Microsoft.EntityFrameworkCore;
using MvcFriends.Models.Friend;
namespace MvcFriends.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options){}
        public DbSet<Friend> Friends { get; set; }
    }

}