using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
namespace FF1.Core.Models.Domain;

public class AppUser : IdentityUser<Guid>
{
	[MaxLength(10)]
	public string FirstName { get; set; } = string.Empty;
	[MaxLength(10)]
	public string LastName { get; set; } = string.Empty;
}
