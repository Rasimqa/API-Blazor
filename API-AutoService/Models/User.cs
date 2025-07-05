using System.ComponentModel.DataAnnotations;

namespace API_BlazorForSome.Models
{
    public class User
    {
        [Key]
        public int id { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public string FullName { get; set; }

        [Required]
        public string Password { get; set; }
        public string Role { get; set; }
    }
}
