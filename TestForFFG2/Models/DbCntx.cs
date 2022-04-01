using Microsoft.EntityFrameworkCore;

namespace TestForFFG2.Models
{
    public class DbCntx : DbContext
    {
        public DbCntx(DbContextOptions<DbCntx> options) : base(options)
        {}

        public DbSet<Clients> clients { get; set; }

        public DbSet<ClientContacts> clientContacts { get; set; }

    }
}
