using Microsoft.EntityFrameworkCore;
using OnlineStore.DAL.Entities;

namespace OnlineStore.DAL.Context
{
    public class StoreContext: DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options): base(options)
        {
            Database.Migrate();
        }

        DbSet<Category> Categories { get; set; }
        DbSet<Product> Products { get; set; }
    }
}
