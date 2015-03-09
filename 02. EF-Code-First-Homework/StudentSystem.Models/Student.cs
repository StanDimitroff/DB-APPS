namespace StudentSystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Student
    {
        public int Id { get; set; }

        [Required]
        public string FullName { get; set; }

        public string PhoneNumber { get; set; }

        public DateTime RegisterDate { get; set; }

        [Required]
        public DateTime Birthday { get; set; }
    }
}