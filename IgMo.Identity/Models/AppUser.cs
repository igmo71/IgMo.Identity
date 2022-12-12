using Microsoft.AspNetCore.Identity;

namespace IgMo.Identity.Models
{
    public class AppUser : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
    }
}
