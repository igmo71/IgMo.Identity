using System.ComponentModel.DataAnnotations;

namespace IgMo.Identity.Models
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "User Name")]
        public string Username { get; set; } = null!;

        [Required]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; } = null!;


        public string? ReturnUrl { get; set; }
    }
}
