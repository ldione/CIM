using System.ComponentModel.DataAnnotations;

namespace Cim.Web.Models.Users
{
    public class LoginModel
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}