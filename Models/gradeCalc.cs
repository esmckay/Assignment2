using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment2.Models
{
    public class gradeCalc
    {//This makes it so all inputs are required and that they are in the range of 0 and 100.
        [Required]
        [Range(0,100)]
        public double assignments { get; set; }

        [Required]
        [Range(0, 100)]
        public double quizzes { get; set; }

        [Required]
        [Range(0, 100)]
        public double groupprojects { get; set; }

        [Required]
        [Range(0, 100)]
        public double exams { get; set; }

        [Required]
        [Range(0, 100)]
        public double intex { get; set; }

    }
}
