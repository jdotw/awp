using Microsoft.EntityFrameworkCore;
using People.Entities;

namespace People.PostgreSQL
{
  public class PeopleContext : DbContext
  {
    public DbSet<Individual> Individuals => Set<Individual>();
    public DbSet<Identity> Identities => Set<Identity>();

    public PeopleContext(DbContextOptions options) : base(options) { }
  }
}
