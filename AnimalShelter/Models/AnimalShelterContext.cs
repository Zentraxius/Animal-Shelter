using Microsoft.EntityFramworkCore;

namespace AnimalShelter.Models
{
  public class AnimalShelterContext : DbContext {
    public DbSet<Type> Types {get; set;}
    public AnimalShelterContext(DbContextOptions options) : base(options) {}
  }
}