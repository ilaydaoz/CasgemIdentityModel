using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CasgemIdentityModel.Dal
{
    public class Context : IdentityDbContext<AppUser, AppRole, int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-AKOHCIC\\SQLEXPRESS;initial catalog=CasgemDbRole;integrated Security=true");
        }
        public DbSet<Product> Products { get; set; }
    }
}
