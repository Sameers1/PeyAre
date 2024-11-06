using Microsoft.EntityFrameworkCore;
using PeyAre.Data;
using PeyAre.Models;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options) { }

    // Define DbSets for your entities
    public DbSet<RepMax> RepMaxes { get; set; }
    public DbSet<GymExerciseLogModel> GymExerciseLogs { get; set; }

}
