using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using BlazorUAS276.Models;

namespace BlazorUAS276.Models
{
    public class Student
    {
        public string studentId { get; set; }

        [Required(ErrorMessage = "Fisrt Name is required")]
        [StringLength(100,MinimumLength =2)]
        public string firstName { get; set; }
        [Required]
        public string lastName { get; set; }
        [Required]
        public DateTime enrollmentDate { get; set; }
    }
}