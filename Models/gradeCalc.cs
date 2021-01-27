using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment2.Models
{
    public class gradeCalc
    {
        [Required]
        public int assignments { get; set; }

        [Required]
        public int quizzes { get; set; }

        [Required]
        public int groupprojects { get; set; }

        [Required]
        public int exams { get; set; }

        [Required]
        public int intex { get; set; }

    }
}
