namespace StudentSystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Homework
    {
        public int Id { get; set; }

        [MaxLength(500)]
        public string Content { get; set; }

        [Required]
        public HomeworkType Type { get; set; }

        [Required]
        public DateTime DateSubmitted { get; set; }

        public int StudentId { get; set; }

        public virtual Student Student { get; set; }

        public int CourseId { get; set; }

        public Course Course { get; set; }
    }
}