using System.ComponentModel.DataAnnotations;

namespace SessionLogin.Models
{
    public class Word
    {
        public int Id { get; set; }
        [Required]
        public string WordName { get; set; }
        [Required]
        public string Difficult { get; set; }
    }
}
