using Microsoft.EntityFrameworkCore;
using TO_DO.Models;
using TO_DO.Seed;

namespace TO_DO.Context;

public class SqlContext: DbContext
{
    public SqlContext(DbContextOptions<SqlContext> options) : base(options) { }
    
    public DbSet<TODO> TODO { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TODO>().HasData(TarefasSeed.Seed);
    }
}
