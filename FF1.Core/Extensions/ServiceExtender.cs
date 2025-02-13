using FF1.Core.Db;
using FF1.Core.Models.Domain;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
namespace FF1.Core.Extensions;

public static class ServiceExtender
{
	public static void ConfigureIdentity(this IServiceCollection services, Action<IdentityConfiguration> configureProvider)
	{
		var providerConfig = new IdentityConfiguration();
		configureProvider(providerConfig);

		var builder = services.AddIdentity<AppUser, IdentityRole<Guid>>(options => options.SignIn.RequireConfirmedAccount = true);
		builder = new IdentityBuilder(builder.UserType, typeof(IdentityRole<Guid>), services);
		builder.AddEntityFrameworkStores<AppDbContext>().AddDefaultTokenProviders();

		services.Configure<DataProtectionTokenProviderOptions>(opt =>
		{
			opt.TokenLifespan = TimeSpan.FromMinutes(providerConfig.LifeTimeMinutes);
		});

		builder.AddTokenProvider(providerConfig.NameIdentityProvider, typeof(DataProtectorTokenProvider<AppUser>));
	}




}
