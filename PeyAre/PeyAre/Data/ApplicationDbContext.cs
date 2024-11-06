using Microsoft.EntityFrameworkCore;
using PeyAre.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options) { }

    // Define DbSets for your entities
    public DbSet<HistoryRPM> HistoryRPMs { get; set; }
    public DbSet<RepMax> RepMaxes { get; set; }
}
