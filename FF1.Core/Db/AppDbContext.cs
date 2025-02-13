using FF1.Core.Models;
using FF1.Core.Models.Domain;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
namespace FF1.Core.Db;

public class AppDbContext(DbContextOptions<AppDbContext> options) : IdentityDbContext<AppUser, IdentityRole<Guid>, Guid>(options)
{
	DbSet<Car> Cars => Set<Car>();
	DbSet<Driver> Drivers => Set<Driver>();
	DbSet<Team> Teams => Set<Team>();
	DbSet<Circuit> Circuits => Set<Circuit>();

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		base.OnModelCreating(modelBuilder);
	}
}
