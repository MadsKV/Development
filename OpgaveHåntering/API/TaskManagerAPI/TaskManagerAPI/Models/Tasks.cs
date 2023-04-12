using System.ComponentModel.DataAnnotations;

namespace TaskManagerAPI.Models
{
    public class Tasks
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public bool Completed { get; set; }
        [Required]
        public DateTime CreatedAt { get; set; }
        [Required]
        public DateTime UpdatedAt { get; set;}


        // Navigation property
        public Users User { get; set; }
        public int UserID { get; set; }
    }
}
