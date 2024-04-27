using System.ComponentModel.DataAnnotations;

namespace ReadApi.Models
{
    public class Course
    {
        [Key]
        public string CourseID { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public int Validity { get; set;}
        [Required]
        public decimal Duration { get; set;}

        [Required]
        public string Thumbnail { get; set; }
        [Required]
        public bool IsActive { get; set;}
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


        public CourseLevel Level { get; set; }

        public CourseCatagory Catagory { get; set; }

        public ICollection<Topic> Topics { get; set; }

        public ICollection<Material> Materials { get; set; }



        public ICollection<UserProgress> Userprogress { get; set; }


    }
}
