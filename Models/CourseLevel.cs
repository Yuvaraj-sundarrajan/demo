using System.ComponentModel.DataAnnotations;

namespace ReadApi.Models
{
    public class CourseLevel
    {
        [Key]
        public string LevelID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string CreatedBy { get; set; }
        [Required]
        public DateTime CreatedAt { get; set; }
        [Required]
        public string ModifiedBy { get; set; }
        [Required]
        public DateTime ModifiedAt { get; set; }

        //One to many
        public ICollection<Course> Courses { get; set;}
    }
}
