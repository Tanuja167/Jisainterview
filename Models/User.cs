
using System.ComponentModel.DataAnnotations;

namespace Jisainterview.Models
{
    public class User
    {

        [Required]
        public string? Username { get;set; }

        [Required]
        [DataType(DataType.Password)]

        public string? Password { get;set; }

        [Required]

        public string? Email { get;set; }
    }
}
