using MarriageAppBackend.Models;
using Microsoft.EntityFrameworkCore;

namespace MarriageAppBackend.Data;

public class DataContext : DbContext
{
  public DataContext(DbContextOptions<DataContext> options) : base(options)
  {

  }

  public DbSet<Potential> Potentials { get; set; }

  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
  }
}
