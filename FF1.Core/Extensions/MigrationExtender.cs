using Microsoft.EntityFrameworkCore;
namespace FF1.Core.Extensions;

public static class DatabaseConfiguration
{
	public static IHost MigrateDatabase<T>(this IHost host) where T : DbContext
	{
		using var scope = host.Services.CreateScope();
		var serviceProvider = scope.ServiceProvider;
		try
		{
			serviceProvider.GetRequiredService<T>().Database.Migrate();
		}
		catch (Exception ex)
		{
		}
		return host;
	}
}
