using System.ComponentModel.DataAnnotations;

namespace ReadApi.Models
{
    public class Material
    {
        [Key]
        public string MaterialID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Filepath { get; set; }
        [Required]
        public int Duration { get; set; }
        [Required]
        public string Type { get; set; }
        [Required]
        public bool IsActive { get; set; }
        [Required]
        public bool IsAvailable { get; set; }
        [Required]
        public string CreatedBy { get; set; }
        [Required]
        public DateTime CreatedAt { get; set; }
        [Required]
        public string ModifiedBy { get; set; }
        [Required]
        public DateTime ModifiedAt { get; set; }

        public Topic Topic { get; set; }

        public Course Course { get; set; }


        public ICollection<UserProgress> users { get; set;}
    }
}