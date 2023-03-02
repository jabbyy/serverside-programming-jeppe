using Microsoft.EntityFrameworkCore;
using server_prog_blazer_app.models;

namespace server_prog_blazer_app.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }

        public DbSet<Todo> Todos { get; set; }
        public DbSet<Hashed> hasheds { get; set; }
    }
}
