using System.ComponentModel.DataAnnotations;

namespace TaskManagerAPI.Models
{
    public class Users
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public DateTime CreatedAt { get; set; }
        [Required]
        public DateTime UpdatedAt { get; set; }

        // Navigation property
        public ICollection<Tasks> Tasks { get; set; }
    }
}
