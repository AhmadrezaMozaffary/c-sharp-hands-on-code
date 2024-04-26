using System.ComponentModel.DataAnnotations;

namespace Rooydaad.Web.Models
{
    public class Credentials
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email address", Prompt = "example@domain.com")]
        public string EmailAddress { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
