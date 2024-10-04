using System.Data.Entity;
using IO.Swagger.Models;

namespace IO.Swagger.Data
{
    /// <summary>
    /// UserDbContext
    /// </summary>
    public class UserDbContext : DbContext
    {
        /// <summary>
        /// OnConfiguring
        /// OnConfiguring
        /// </summary>
        /// <param name="options"></param>
        protected override void OnConfiguring(DbContextOptionsBuilder options) =>
            options.UseSqlite("DataSource=indexCardsDb; Cache=Shared");

        public DbSet<User> User { get; set; }
    }
}
