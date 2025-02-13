using FF1.Core.Db;
using FF1.Core.Extensions;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Serilog;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

#region Database


var sqlConBuilder = new SqlConnectionStringBuilder
{
		ConnectionString = builder.Configuration.GetConnectionString("SqlDbConnection")
};
Log.Information(sqlConBuilder.ConnectionString);
builder.Services.AddDbContext<AppDbContext>(
		opt => opt.UseSqlServer(sqlConBuilder.ConnectionString).ConfigureWarnings(warning => warning.Ignore(CoreEventId.NavigationBaseIncludeIgnored))
);

#endregion

#region Identity
builder.Services.ConfigureIdentity(opt =>
{
	opt.NameIdentityProvider = builder.Configuration["TokenProvider:NameIdentityProvider"] ?? "DefaultProvider";
	opt.LifeTimeMinutes = int.Parse(builder.Configuration["TokenProvider:LifeTimeMinutes"] ?? "60");
});
#endregion


builder.Services.AddCors(o =>
{
	o.AddPolicy("AllowAll", policyBuilder =>
			policyBuilder
					.AllowAnyHeader()
					.AllowAnyMethod()
					.AllowCredentials()
					.SetIsOriginAllowed(e => true)
	);
});

var app = builder.Build();

app.MigrateDatabase<AppDbContext>();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();
app.Run();

