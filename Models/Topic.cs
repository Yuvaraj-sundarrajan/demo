using System.ComponentModel.DataAnnotations;

namespace ReadApi.Models
{
    public class Topic
    {
        [Key]
        public string TopicID { get; set; }
        [Required]
        public string TopicName { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public bool IsActive { get; set; }
        [Required]
        public string CreatedBy { get; set; }
        [Required]
        public DateTime CreatedAt { get; set; }
        [Required]
        public string ModifiedBy { get; set; }
        [Required]
        public DateTime ModifiedAt { get; set; }


        public Course Course { get; set; }

        public ICollection<Material> Materials { get; set; }

        public ICollection<UserProgress> UsersProgress { get; set; }

    }
}
