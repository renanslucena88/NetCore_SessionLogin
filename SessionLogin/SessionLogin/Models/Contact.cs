using System.ComponentModel.DataAnnotations;

namespace SessionLogin.Models
{
    public class Contact
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        [MaxLength(70)]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [MaxLength(70)]
        public string Subject { get; set; }
        [Required]
        [MaxLength(200)]
        public string Message { get; set; }

    }
}
