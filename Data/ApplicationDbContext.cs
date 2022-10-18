
using AbbyTryout.Model;
using Microsoft.EntityFrameworkCore;

namespace AbbyTryout.Data;
public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {

    }
    public DbSet<AlhasrTabel> AlhasrTabel { get; set; }
}
