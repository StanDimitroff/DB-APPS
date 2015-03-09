namespace StudentSystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Homework
    {
        public int Id { get; set; }

        public string Content { get; set; }

        public HomeworkType Type { get; set; }

        public DateTime DateSubmitted { get; set; }
    }
}
