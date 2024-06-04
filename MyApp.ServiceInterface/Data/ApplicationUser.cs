using Microsoft.AspNetCore.Identity;
using ServiceStack.DataAnnotations;

namespace MyApp.Data;

// Add profile data for application users by adding properties to the ApplicationUser class
[Alias("AspNetUsers")]
public class ApplicationUser : IdentityUser
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? DisplayName { get; set; }
    public string? ProfileUrl { get; set; }
}
